using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;

namespace MineTube
{
    public partial class frmPlaylist : MaterialForm
    {
        #region  Fields

        int _TotalResult = 0;

        bool _ImageIsNullOrEmpty = false;

        bool _IsNextPageTokenAvailable = false;

        bool _IsPrevPageTokenAvailable = false;

        bool _IsProcessing = false;

        string _ChannelId = "";

        string _PageNextToken;

        string _PagePrevToken;

        string _ThumbURL;

        string _PlaylistTitle;

        string _OwnerName;

        string _PublishedDate;

        string _Descrirption;

        List<ListViewItem> _videoItems;

        delegate void SetTitle(string Title);

        delegate void SetOwner(string OwnerTitle);

        delegate void SetDate(string PublishedDate);

        delegate void SetDescription(string Description);

        delegate void SetThumbs(string ThumbURL);

        delegate void SetListViewItem(List<ListViewItem> item);

        delegate void UpdateProgress(int i);

        #endregion

        #region Constructor
        public frmPlaylist()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);

            
            lblDate.Text = "";
            listVideos.Columns[11].Dispose();
            pbStatus.Visible = false;
            _ImageIsNullOrEmpty = true;
            lblChannelOwner.Text = "";
            
        }
        #endregion

        #region Controls's events

        private static string GetPlaylistIdFromUrl(string urlParams)
        {
            var res = "";
            var urlPatern = @"/^.*(youtu.be\/|list=)([^#\&\?]*).*/";
            try
            {
                var match = Regex.Match(urlParams, urlPatern);
                if (match.Success)
                {
                    res = match.Value;
                }
            }
            catch (Exception)
            {
                res = "";
            }
            return res;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            
            btnGrab.Enabled = false;
            if (txtboxUrl.Text != "")
            {
                pbStatus.Visible = true;
                lblStatus.Visible = true;
                ClearAll();
                if (listVideos.Items.Count != 0)
                {
                    lblStatus.Text = "Refreshing...";
                }
                else
                {
                    lblStatus.Text = "Getting data from YouTube Service...";
                }

                Cursor.Current = Cursors.WaitCursor;
                listVideos.Items.Clear();
                _IsProcessing = true;

                bwFetch.RunWorkerAsync(txtboxUrl.Text);   
            }
        }
        
        private void ClearAll()
        {
            lblDate.Text = "n/a";
            lblCounter.Text = "n/a";
            lblChannelOwner.Text = "";
            lblTitlePlaylist.Text = "Data is not available";
            picThumbs.Image = Properties.Resources.thumbnail_video;
            richDescription.Clear();
        }      
        
        protected void Back()
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmHome(), "Backing to Home...");
            Initial.ShowDialog();
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_IsProcessing == false)
            {
                Back();
            }
            else
            {
                var msg = MessageBox.Show("Do you want to cancel this process?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.OK)
                    Back();
                else return;
            }       
        }    

        private void listDataMenu_Opening(object sender, CancelEventArgs e)
        {
            if (listVideos.Items.Count == 0)
            {
                e.Cancel = true;
            }

            if(listVideos.SelectedItems.Count == 0 || listVideos.Items.Count < 0)
            {
                e.Cancel = false;
                getPublisherInformationToolStripMenuItem.Enabled = false;
                getVideoInformationToolStripMenuItem.Enabled = false;
                copyVideoURLToolStripMenuItem.Enabled = false;
                clearToolStripMenuItem.Enabled = false;
                clearAllItemsToolStripMenuItem.Enabled = true;
                downloadWithInternetDownloadManagerToolStripMenuItem.Enabled = false;
                downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Enabled = false;
            }

            if (listVideos.SelectedItems.Count > 0)
            {
                e.Cancel = false;
                getPublisherInformationToolStripMenuItem.Enabled = true;
                getVideoInformationToolStripMenuItem.Enabled = true;
                copyVideoURLToolStripMenuItem.Enabled = true;
                clearToolStripMenuItem.Enabled = true;
                clearAllItemsToolStripMenuItem.Enabled = true;
                ListViewItem item = listVideos.SelectedItems[0];

                if (item.SubItems[1].Text.Contains("[Queued] "))
                {
                    downloadWithInternetDownloadManagerToolStripMenuItem.Enabled = false;
                    downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Enabled = false;
                }
                else
                {
                    downloadWithInternetDownloadManagerToolStripMenuItem.Enabled = true;
                    downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Enabled = true;
                }
            }           
        }

        private void getPublisherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var publisherId = item.SubItems[11].Text;
            frmChannelInfo channel = new frmChannelInfo(publisherId);
            channel.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listVideos.SelectedItems[0].Remove();
            lblCounter.Text = "Displayed " + listVideos.Items.Count.ToString() + " videos in " + _TotalResult.ToString() + " videos total";
        }

        private void copyVideoURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[10].Text;
            Clipboard.SetText(urlVideo);
        }

        private void getVideoInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[10].Text;
            var videoId = urlVideo.Substring(32);
            frmVideo video = new frmVideo(videoId);
            video.btnBack.Visible = false;
            video.ControlBox = true;
            video.ShowDialog();          
        }

        private void clearAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
            txtboxUrl.Clear();
            listVideos.Items.Clear();
            lblStatus.Text = "There are nothing to display";
            lblStatus.Visible = true;
            lblCounter.Visible = false;
        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            lblCounter.Text = "";
            
        }

        private void copyThumbnailURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(picThumbs.ImageLocation);
        }

        private void menuThumbs_Opening(object sender, CancelEventArgs e)
        {
            if (_ImageIsNullOrEmpty == true)
            {
                copyThumbnailURLToolStripMenuItem.Enabled = false;
                saveThumbnailImageToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyThumbnailURLToolStripMenuItem.Enabled = true;
                saveThumbnailImageToolStripMenuItem.Enabled = true;
            }
        }

        private void saveThumbnailImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveImg.Filter = "JPG Image (*.jpg)|*.jpg;*.jpeg|PNG Image (*.png)|*.png";
            var defDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveImg.InitialDirectory = defDirectory;
            saveImg.RestoreDirectory = true;
            saveImg.FileName = Path.GetFileName(picThumbs.ImageLocation);
            saveImg.DefaultExt = "JPG files (*.jpg)|*.jpg;*.jpeg";
            var saveResult = saveImg.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                switch (Path.GetExtension(saveImg.FileName))
                {
                    case ".jpg":
                    case ".jpeg":
                        picThumbs.Image.Save(saveImg.FileName, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        picThumbs.Image.Save(saveImg.FileName, ImageFormat.Png);
                        break;
                    
                    default:
                        picThumbs.Image.Save(saveImg.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void lblChannelOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChannelInfo info = new frmChannelInfo(_ChannelId);
            info.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void downloadWithOurDownloadToolcomingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[10].Text;
            item.SubItems[1].Text = "[Queued] " + item.SubItems[1].Text;
            frmDownloads download = new frmDownloads(urlVideo);
            download.Show();
        }

        private static string GetIDMInstallationFolderDependOnOSArch()
        {
            var res = "";
            string name = "SOFTWARE\\DownloadManager";
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
            res = registryKey.GetValue("ExePath", "").ToString();
            return res;
        }

        private void downloadWithInternetDownloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var IDMPath = GetIDMInstallationFolderDependOnOSArch();
            var item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[10].Text;
            var videoTemp = item.SubItems[1].Text;
            var videoName = "";
            if (videoTemp.Contains("[Queued] "))
            {
                videoName = videoTemp.Substring(8);
            }
            else
            {
                videoName = videoTemp;
            }
            var urlDownload = "";

            using (var service = Client.For(YouTube.Default))
            {
                var video = service.GetVideo(urlVideo);
                urlDownload = video.Uri;
            }

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = IDMPath,
                    Arguments = "idman /d " + urlDownload + " /f " + videoName
                }
            };         
            process.Start();
            process.WaitForExit();
        }

        private void listVideos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[10].Text;
            var videoId = urlVideo.Substring(32);
            frmVideo video = new frmVideo(videoId);
            video.btnBack.Visible = false;
            video.ControlBox = true;
            video.ShowDialog();
        }

        private void ThreadProcSafeSetGUI()
        {            
            UpdateTitle(_PlaylistTitle);
            UpdateOwnerName(_OwnerName);
            UpdateListVideo(_videoItems);
            UpdatePublishDate(_PublishedDate);
            UpdateDescription(_Descrirption);
            UpdateThumbURL(_ThumbURL);       
        }

        private void UpdateTitle(string Title = "There are not title.")
        {
            if (lblTitlePlaylist.InvokeRequired)
            {
                SetTitle setTitle = new SetTitle(UpdateTitle);
                lblTitlePlaylist.Invoke(setTitle, new object[] { Title });
            }
            else
                lblTitlePlaylist.Text = Title;
        }
        
        private void UpdateOwnerName(string OwnerName = "n/a")
        {
            if (lblChannelOwner.InvokeRequired)
            {
                SetOwner setOwner = new SetOwner(UpdateOwnerName);
                lblChannelOwner.Invoke(setOwner, new object[] { OwnerName });
            }
            else
                lblChannelOwner.Text = OwnerName;
        }

        private void UpdateDescription(string Description)
        {
            if (richDescription.InvokeRequired)
            {
                SetDescription setDescription = new SetDescription(UpdateDescription);
                richDescription.Invoke(setDescription, new object[] { Description });
            }
            else
                richDescription.Text = Description;
        }

        private void UpdatePublishDate(string Date = "Can't retrieving data...")
        {
            if (lblDate.InvokeRequired)
            {
                SetDate setDate = new SetDate(UpdatePublishDate);
                lblDate.Invoke(setDate, new object[] { Date });
            }
            else
                lblDate.Text = Date;
        }

        private void UpdateThumbURL(string Url = "")
        {
            if (Url != "")
            {
                if (picThumbs.InvokeRequired)
                {
                    SetThumbs setThumbURL = new SetThumbs(UpdateThumbURL);
                    picThumbs.Invoke(setThumbURL, new object[] { Url });
                }
                else
                {
                    picThumbs.ImageLocation = Url;
                    _ImageIsNullOrEmpty = false;
                }
            }
            
        }

        private void UpdatePrevToken(string PrevToken)
        {

        }

        private void UpdateNextToken(string NextToken)
        {

        }

        private void CheckPageTokenAvailable()
        {
            if (_IsPrevPageTokenAvailable == true)
                btnPrev.Enabled = true;
            else
                btnPrev.Enabled = false;

            if (_IsNextPageTokenAvailable == true)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
        }

        private void UpdateListVideo(List<ListViewItem> lstItem)
        {
            if (listVideos.InvokeRequired)
            {
                SetListViewItem setListVideo = new SetListViewItem(UpdateListVideo);
                Invoke(setListVideo, new object[] { lstItem });
            }
            else
            {
                foreach (var item in lstItem)
                {
                    listVideos.Items.Add(item);
                }
            }
        }

        private void txtboxUrl_Click(object sender, EventArgs e)
        {
            txtboxUrl.SelectAll();
        }

        private void bwFetch_DoWork(object sender, DoWorkEventArgs e)
        {
            var inputId = e.Argument.ToString();
            
            YoutubeVideo[] videos = YouTubeApis.GetVideoOfPlaylist(inputId);
            YouTubePlaylist playlist = new YouTubePlaylist(inputId);

            _PlaylistTitle = playlist.PlaylistTitle;
            _ThumbURL = playlist.Thumbs;
            _PublishedDate = playlist.DatePublished.Day.ToString() + "/" + playlist.DatePublished.Month.ToString() + "/" + playlist.DatePublished.Year.ToString();
            _Descrirption = playlist.Description;
            _OwnerName = playlist.OwnerTitle;
            _ChannelId = playlist.OwnerID;
            if (playlist.NextPageToken != null)
            {
                _PageNextToken = playlist.NextPageToken;
                _IsNextPageTokenAvailable = true;
            }
            else
            {
                _IsNextPageTokenAvailable = false;
            }

            if (playlist.PrevPageToken != null)
            {
                _PagePrevToken = playlist.PrevPageToken;
                _IsPrevPageTokenAvailable = true;
            }
            else
            {
                _IsPrevPageTokenAvailable = false;
            }
            int index = 1;
            _videoItems = new List<ListViewItem>();
            foreach (var video in videos)
            {
                var item = new ListViewItem();
                item.Text = index.ToString();
                item.SubItems.Add(video.Title);
                item.SubItems.Add(video.Duration);
                item.SubItems.Add(video.ChannelTitle);
                item.SubItems.Add(video.DatePublished.Day.ToString() + "/" + video.DatePublished.Month.ToString() + "/" + video.DatePublished.Year.ToString());
                item.SubItems.Add(video.View.Value.ToString("N0"));
                item.SubItems.Add(video.CommentCount.Value.ToString("N0"));
                item.SubItems.Add(video.Quality);
                item.SubItems.Add(video.Like.Value.ToString("N0"));
                item.SubItems.Add(video.Dislike.Value.ToString("N0"));
                item.SubItems.Add("https://www.youtube.com/watch?v=" + video.Id);
                item.SubItems.Add(video.ChannelId);
                index++;

                _videoItems.Add(item);
            }
            
            _TotalResult = playlist.TotalResults;
            
        }

        private void bwFetch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Visible = false;
            pbStatus.Visible = false;
            ThreadProcSafeSetGUI();
            btnGrab.Enabled = true;
            CheckPageTokenAvailable();
            lblCounter.Text = "Displayed " + listVideos.Items.Count.ToString() + " videos in " + _TotalResult.ToString() + " videos total";
            _IsProcessing = false;
            Cursor.Current = Cursors.Default;
            lblCounter.Visible = true;
        }

        private void bwFetch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            
        }
        #endregion
    }
}
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace YoutubeApisDemo
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

        #endregion

        #region
        public frmPlaylist()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            
            lblDate.Text = "n/a";
            listVideos.Columns[11].Dispose();
            
            _ImageIsNullOrEmpty = true;
            lblChannelOwner.Visible = false;
            
        }
        #endregion

        #region Controls's events
        private void btnGet_Click(object sender, EventArgs e)
        {
            btnGrab.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            listVideos.Items.Clear();
            _IsProcessing = true;

            GetPlaylistInformation(txtboxUrl.Text);    
                   
            Thread t = new Thread(new ThreadStart(ThreadProcSafeSetGUI));
            t.Start();
            CheckPageTokenAvailable();

            _IsProcessing = false;
            btnGrab.Enabled = true;
            Cursor.Current = Cursors.Default;
            
        }
        
        private void GetPlaylistInformation(string inputId)
        {                                             
            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {             
                YoutubeVideo[] videos = YouTubeApis.GetVideoOfPlaylist(inputId);
                YouTubePlaylist playlist = new YouTubePlaylist(inputId);

                _PlaylistTitle = playlist.PlaylistTitle;
                _ThumbURL = playlist.Thumbs;
                _PublishedDate = playlist.DatePublished.Day.ToString() + "/" + playlist.DatePublished.Month.ToString() + "/" + playlist.DatePublished.Year.ToString();
                _Descrirption = playlist.Description;
                _OwnerName = playlist.OwnerTitle;              
                _ChannelId = playlist.OwnerID;
                if (playlist.NextPageToken != "")
                {
                    _PageNextToken = playlist.NextPageToken;
                    _IsNextPageTokenAvailable = true;
                }
                else
                {
                    _IsNextPageTokenAvailable = false;
                }

                if (playlist.PrevPageToken != "")
                {
                    _PagePrevToken = playlist.PrevPageToken;
                    _IsPrevPageTokenAvailable = true;
                }
                else
                {
                    _IsPrevPageTokenAvailable = true;
                }

                _PagePrevToken = playlist.PrevPageToken;

                int index = 1;

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
                    _videoItems = new List<ListViewItem>();
                    _videoItems.Add(item);
                }            
                _TotalResult = playlist.TotalResults;               
            }
            
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

            if(listVideos.SelectedItems.Count == 0 && listVideos.Items.Count > 0)
            {
                e.Cancel = false;
                getPublisherInformationToolStripMenuItem.Enabled = false;
                getVideoInformationToolStripMenuItem.Enabled = false;
                copyVideoURLToolStripMenuItem.Enabled = false;
                clearToolStripMenuItem.Enabled = false;
                clearAllItemsToolStripMenuItem.Enabled = true;
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

                if (item.SubItems[1].Text.Contains("[Q] "))
                {
                    downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Enabled = false;
                }
                else
                {
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
            listVideos.Items.Clear();
            lblStatus.Visible = true;
            lblCounter.Visible = false;
        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            lblCounter.Text = "";
            
        }

        private void FrmPlaylist_OnSetTitle(string Title)
        {
            lblTitlePlaylist.Text = Title;
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
            frmDownload download = new frmDownload(urlVideo, item.SubItems[1].Text);
            item.SubItems[1].Text = "[Q] " + item.SubItems[1].Text;
            
            download.Show();
        }

        private static string GetIDMInstallationFolderDependOnOSArch()
        {
            var res = "";
            string name = "SOFTWARE\\DownloadManager";
            Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(name);
            res = registryKey.GetValue("ExePath", "").ToString();
            return res;
        }

        private void downloadWithInternetDownloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var IDMPath = GetIDMInstallationFolderDependOnOSArch();
            var video = new YoutubeVideo();
            var DownloadUrl = video.DownloadUrl;
            var VideoName = video.Title;
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = IDMPath,
                    Arguments = "idman /d " + DownloadUrl + " /f " + video.Title
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
                Invoke(setTitle, new object[] { Title });
            }
            else
                lblTitlePlaylist.Text = Title;
        }
        
        private void UpdateOwnerName(string OwnerName = "n/a")
        {
            if (lblChannelOwner.InvokeRequired)
            {
                SetOwner setOwner = new SetOwner(UpdateOwnerName);
                Invoke(setOwner, new object[] { OwnerName });
            }
            else
                lblChannelOwner.Text = OwnerName;
        }

        private void UpdateDescription(string Description)
        {
            if (richDescription.InvokeRequired)
            {
                SetDescription setDescription = new SetDescription(UpdateDescription);
                Invoke(setDescription, new object[] { Description });
            }
            else
                richDescription.Text = Description;
        }

        private void UpdatePublishDate(string Date = "Can't retrieving data...")
        {
            if (lblDate.InvokeRequired)
            {
                SetDate setDate = new SetDate(UpdateDescription);
                Invoke(setDate, new object[] { Date });
            }
            else
                lblDate.Text = Date;
        }

        private void UpdateThumbURL(string URL = "")
        {
            if (picThumbs.InvokeRequired)
            {
                SetThumbs setThumbURL = new SetThumbs(UpdateThumbURL);
                Invoke(setThumbURL, new object[] { URL });
            }
            else
             picThumbs.ImageLocation = URL;
            _ImageIsNullOrEmpty = false;
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
                foreach(var item in _videoItems)
                {
                    listVideos.Items.Add(item);
                }
            }
        }    
        #endregion
    }
}
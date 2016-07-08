using MaterialSkin;
using MaterialSkin.Controls;

using YoutubeExtractor;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YoutubeApisDemo
{
    public partial class frmPlaylist : MaterialForm
    {
        public frmPlaylist()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            prbStatus.Visible = false;
            lblDate.Text = "n/a";
            listVideos.Columns[11].Dispose();
            
            ImageIsNullOrEmpty = true;
            lblChannelOwner.Visible = false;
            
        }
        int count = 0;
        bool ImageIsNullOrEmpty = false;
        private void btnGet_Click(object sender, EventArgs e)
        {
            //prbStatus.Visible = true;
            
            GetPlaylistInfo(txtboxUrl.Text);
        }
        string ChannelId = "";
        private void GetPlaylistInfo(string inputId)
        {
            btnGrab.Enabled = false;
            lblCounter.Text = "Working on it...";
            lblCounter.Visible = true;
            Cursor.Current = Cursors.WaitCursor;
            listVideos.Items.Clear();
            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                YoutubeVideo[] videos = YouTubeApis.GetVideoOfPlaylist(inputId);
                YouTubePlaylist playlist = new YouTubePlaylist(inputId);
                try
                {                  
                    picThumbs.ImageLocation = playlist.Thumbs;
                    ImageIsNullOrEmpty = false;
                    lblTitlePlaylist.Text = playlist.PlaylistTitle;
                    lblDate.Text = playlist.DatePublished.Day.ToString() + "/" + playlist.DatePublished.Month.ToString() + "/" + playlist.DatePublished.Year.ToString();
                    richDescription.Text = playlist.Description;
                    lblChannelOwner.Text = playlist.OwnerTitle;
                    lblChannelOwner.Visible = true;
                    ChannelId = playlist.OwnerID;
                    int index = 1;
                    prbStatus.Maximum = videos.Length;
                    
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
                        listVideos.Items.Add(item);                      
                        index++;                        
                    }
                                  
                    lblStatus.Visible = false;
                    
                    if (playlist.NextPageToken == "")
                    {
                        btnNext.Enabled = false;
                    }
                    if(playlist.NextPageToken != "")
                    {
                        btnNext.Enabled = true;
                    }
                }
                catch(AggregateException ex)
                {
                    foreach(var e in ex.InnerExceptions)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                count = playlist.TotalResults;
                lblCounter.Text = "Displayed " + listVideos.Items.Count.ToString() + " videos in " + playlist.TotalResults.ToString() + " videos total";
            }
            btnGrab.Enabled = true;
            
            Cursor.Current = Cursors.Default;
        }       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmHome(), "Backing to Home...");
            Initial.ShowDialog();            
            this.Close();
        }

        private void bwFetch_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void bwFetch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Visible = false;
            
            prbStatus.Value = e.ProgressPercentage;
        }

        private void bwFetch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (listVideos.Items.Count == 0)
                lblStatus.Visible = true;
            else
                lblStatus.Visible = false;
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
                //if(item.SubItems[1].Text.Contains("[Downloading] "))
                //{
                //    downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Enabled = false;
                //}
                //else
                //{
                //    downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Enabled = true;
                //}
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
            lblCounter.Text = "Displayed " + listVideos.Items.Count.ToString() + " videos in " + count.ToString() + " videos total";

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

        private void copyThumbnailURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(picThumbs.ImageLocation);
        }

        private void menuThumbs_Opening(object sender, CancelEventArgs e)
        {
            if (ImageIsNullOrEmpty == true)
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
            //FileStream fs = new FileStream

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
            frmChannelInfo info = new frmChannelInfo(ChannelId);
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
            item.SubItems[1].Text = "[Downloading] " + item.SubItems[1].Text;
            
            download.Show();
        }

        private void downloadWithInternetDownloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var UrlVideo = item.SubItems[10].Text;
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(UrlVideo);
            VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
            var videoDownloadUrl = video.DownloadUrl;

            Process.Start("C:\\Program Files (x86)\\Internet Download Manager\\IDMan.exe", "/a /d " + videoDownloadUrl);
        }

        private void listVideos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
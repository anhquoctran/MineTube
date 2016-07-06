using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

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
            listVideos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listVideos.Columns[9].Dispose();
            btnNext.Visible = false;
            btnPrev.Visible = false;
        }
        //string Id = "";

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetPlaylistInfo(txtboxUrl.Text);
        }

        private void GetPlaylistInfo(string inputId)
        {
            listVideos.Items.Clear();
            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                          
                YoutubeVideo[] videos = YouTubeApis.GetPlaylistInfo(inputId);
                try
                {
                    btnGet.Enabled = false;
                    foreach (var video in videos)
                    {
                        var item = new ListViewItem();
                        item.Text = video.Title;
                        item.SubItems.Add(video.Duration);
                        item.SubItems.Add(video.ChannelTitle);
                        item.SubItems.Add(video.View.Value.ToString("N0"));
                        item.SubItems.Add(video.CommentCount.Value.ToString("N0"));
                        item.SubItems.Add(video.Quality);
                        item.SubItems.Add(video.Like.Value.ToString("N0"));
                        item.SubItems.Add(video.Dislike.Value.ToString("N0"));
                        item.SubItems.Add("https://www.youtube.com/watch?v=" + video.Id);
                        item.SubItems.Add(video.ChannelId);

                        listVideos.Items.Add(item);

                        //var data = new[]
                        //{
                        //    new [] {video.Title, video.Duration, video.ChannelTitle, video.View.Value.ToString("N0"), video.CommentCount.Value.ToString("N0"), video.Quality, video.Like.Value.ToString("N0"), video.Dislike.Value.ToString("N0"), "https://www.youtube.com/watch?v=" + video.Id, video.ChannelId}
                        //};
                        //foreach (var content in data)
                        //{
                        //    var item = new ListViewItem(content);
                        //    listVideos.Items.Add(item);
                        //}
                    }
                    listVideos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                    lblStatus.Visible = false;
                    prbStatus.Visible = false;
                    btnPrev.Visible = true;
                    btnPrev.Enabled = false;
                    btnNext.Visible = true;
                    btnGet.Enabled = true;

                }
                catch(AggregateException ex)
                {
                    foreach(var e in ex.InnerExceptions)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            Close();
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
            }
            
        }

        private void getPublisherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var publisherId = item.SubItems[4].Text;
            frmChannelInfo channel = new frmChannelInfo(publisherId);
            channel.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listVideos.SelectedItems[0].Remove();
            
        }

        private void copyVideoURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[3].Text;
            Clipboard.SetText(urlVideo);
        }

        private void getVideoInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listVideos.SelectedItems[0];
            var urlVideo = item.SubItems[3].Text;
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
        }       
    }
}
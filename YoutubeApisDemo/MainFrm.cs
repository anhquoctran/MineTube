using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeApisDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();

            if (IsInternetAvailable())
                btnSearch.Enabled = true;
            else btnSearch.Enabled = false;

            lblDate.Text = "Ngày xuất bản: ";
            lblDescription.Text = "";
            lblLikeDislike.Text = "0 like - 0 dislike";
            lblPublisher.Text = "Người đăng: ";
            lblVideoTitle.Text = "";
            lblView.Text = "0 lượt xem";
            lblComment.Text = "0 bình luận";
            picVideoThumb.Image = Properties.Resources.thumbnail_video;
            btnPlay.Visible = false;
            lblPub.Text = "";
            lblDimension.Visible = false;
            lblDefinition.Visible = false;
            lblDuration.Visible = false;
            btnReset.Enabled = false;
        }

        protected string VideoUrl = "";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtboxSearch.Text;
            if (input == "")
                MessageBox.Show("Không được bỏ trống ô tìm kiểm!");
            else if (input.Contains("https://www.youtube.com/watch?v="))
            {
                
                var stringResult = input.Substring(32);
                GetInfo(stringResult);
                VideoUrl = "https://www.youtube.com/v/" + stringResult;
            }
            else if (input.Contains("https://youtu.be/"))
            {
                
                var stringResult = input.Substring(17);
                GetInfo(stringResult);
                VideoUrl = "https://www.youtube.com/v/" + stringResult;
            }
            else
            {
                GetInfo(input);
                //picVideoThumb.Image = Video.Thumb.Standard
                VideoUrl = "https://www.youtube.com/v/" + input;
            }
        }

        string ChannelId = "";

        private void GetInfo(string Id)
        {
            YoutubeVideo Video = new YoutubeVideo(Id);
            lblVideoTitle.Text = Video.Title;
            lblPub.Text = Video.ChannelTitle;
            lblDate.Text = "Thời gian đăng: " + Video.DatePublished.Hour.ToString() + " giờ " + Video.DatePublished.Month + " phút " + Video.DatePublished.Second.ToString() + " giây / ngày " + Video.DatePublished.Day.ToString() + " tháng " + Video.DatePublished.Month.ToString() + " năm " + Video.DatePublished.Year.ToString();
            lblDescription.Text = Video.Description;
            lblDuration.Visible = true;
            if (Video.Thumb == null)
            {
                picVideoThumb.Image = Properties.Resources.thumbnail_video;
            }
            else
            {
                picVideoThumb.ImageLocation = Video.Thumb;
            }

            if (Video.Quality == "HD")
            {
                lblDefinition.Visible = true;
                lblDefinition.Text = Video.Quality;
            }
            else
            {
                lblDefinition.Visible = false;
               
            }

            lblComment.Text = Video.CommentCount.Value.ToString("N0") + " bình luận";
            lblView.Text = Video.View.Value.ToString("N0") + " lượt xem";
            lblLikeDislike.Text = Video.Like.Value.ToString("N0") + " lượt thích - " + Video.Dislike.Value.ToString("N0") + " lượt không thích";
            btnPlay.Visible = true;
            ChannelId = Video.ChannelId;
            lblDuration.Text = Video.Duration;
            lblDimension.Visible = true;
            if (Video.Dimension == "2D")
            {
                lblDimension.BackColor = Color.DimGray;
                lblDimension.Text = Video.Dimension;
            }

            if(Video.Dimension == "3D")
            {
                lblDimension.BackColor = Color.FromArgb(0, 192, 0);
                lblDimension.Text = Video.Dimension;
            }

            rchtxtTags.Clear();
            if (Video.VideoTags != null)
            {
                for (int i = 0; i < Video.VideoTags.Length; i++)
                {
                    rchtxtTags.Text += string.Join(", ", Video.VideoTags);
                }
            }
            btnReset.Enabled = true;
        }

        private void txtboxSearch_Click(object sender, EventArgs e)
        {
            string metadata = Clipboard.GetText();
            if (metadata != "" || metadata != null)
            {
                txtboxSearch.Clear();
                if (metadata.Contains("https://www.youtube.com/watch?v=") || metadata.Contains("https://youtu.be/"))
                {
                    txtboxSearch.Text = metadata;
                    btnSearch_Click(sender, e);
                }
                else return;
            }
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.White;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.Black;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            VideoPlayer play = new VideoPlayer();
            play.SendVideoUrl(VideoUrl);
            play.SendVideoTitle(lblVideoTitle.Text);
            play.ShowDialog();
        }

        private void lblPub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/" + ChannelId);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            string metadata = Clipboard.GetText();
            if (metadata != "" || metadata != null)
            {
                txtboxSearch.Clear();
                if (metadata.Contains("https://www.youtube.com/watch?v=") || metadata.Contains("https://youtu.be/"))
                {
                    txtboxSearch.Text = metadata;
                    btnSearch_Click(sender, e);
                }
                else return;
            }
        }

        private bool IsInternetAvailable()
        {
            var res = false;

            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("https://www.youtube.com/"))
                    {
                        res = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return res;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblDate.Text = "Ngày xuất bản: ";
            lblDescription.Text = "";
            lblLikeDislike.Text = "0 like - 0 dislike";
            lblPublisher.Text = "Người đăng: ";
            lblVideoTitle.Text = "";
            lblView.Text = "0 lượt xem";
            lblComment.Text = "0 bình luận";
            picVideoThumb.Image = Properties.Resources.thumbnail_video;
            btnPlay.Visible = false;
            lblPub.Text = "";
            lblDimension.Visible = false;
            lblDefinition.Visible = false;
            lblDuration.Visible = false;
            txtboxSearch.Clear();
        }
    }
}

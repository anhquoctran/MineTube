using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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
            picIcon.Image = Icon.ToBitmap();
            lblTitle.Text = Text;
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
            lblCategory.Text = "Thể loại: ";
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


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
            if (Video.ThumbUrl == null)
            {
                picVideoThumb.Image = Properties.Resources.thumbnail_video;
            }
            else
            {
                picVideoThumb.ImageLocation = Video.ThumbUrl;
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
            string id = Video.CategoryId;

            switch (id)
            {
                case "1":
                    lblCategory.Text = "Thể loại: Phim & Hoạt họa";
                    break;
                case "2":
                    lblCategory.Text = "Thể loại: Xe & Phương tiện";
                    break;
                case "10":
                    lblCategory.Text = "Thể loại : Âm nhạc";
                    break;
                case "15":
                    lblCategory.Text = "Thể loại: Thú cưng & Động vật";
                    break;
                case "17":
                    lblCategory.Text = "Thể loại: Thể thao";
                    break;
                case "19":
                    lblCategory.Text = "Thể loại: Du lịch và sự kiện";
                    break;
                case "20":
                    lblCategory.Text = "Thể loại: Trò chơi";
                    break;
                case "22":
                    lblCategory.Text = "Thể loại: Mọi người & Nhật ký";
                    break;
                case "23":
                    lblCategory.Text = "Thể loại: Hài kịch";
                    break;
                case "24":
                    lblCategory.Text = "Thể loại: Giải trí";
                    break;
                case "25":
                    lblCategory.Text = "Thể loại: Tin tức và chính trị";
                    break;
                case "26":
                    lblCategory.Text = "Thể loại: Phong cách & Lối sống";
                    break;
                case "27":
                    lblCategory.Text = "Thể loại: Giáo dục";
                    break;
                case "28":
                    lblCategory.Text = "Thể loại: Khoa học & Công nghệ";
                    break;
                case "29":
                    lblCategory.Text = "Thể loại: Hoạt động & Phi lợi nhuận";
                    break;
                
                default: lblCategory.Text = "Thể loại: Không xác định";
                    break;
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
            ChannelInfo ci = new ChannelInfo();
            ci.getChannelId(ChannelId);
            ci.ShowDialog();
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
            lblCategory.Text = "Thể loại: ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlVideoInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        

        
    }
}

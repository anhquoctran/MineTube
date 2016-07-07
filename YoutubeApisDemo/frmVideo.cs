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
using MaterialSkin;
using MaterialSkin.Controls;

namespace YoutubeApisDemo
{
    public partial class frmVideo : MaterialForm
    {
        public frmVideo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red100, TextShade.WHITE);
            lblVersion.Text = "Current version: " + Application.ProductVersion + " - Copyright © 2016 Anh Quoc Tran";

            if (IsInternetAvailable())
                btnSearch.Enabled = true;
            else btnSearch.Enabled = false;
            lblVideoTitle.Text = "We haven't received data...";
            lblDate.Text = "Published date: ";
            lblDescription.Text = "";
            lblLikeDislike.Text = "0 likes - 0 dislikes";
            lblPublisher.Text = "Publisher: ";
            lblVideoTitle.Text = "";
            lblView.Text = "0 views";
            lblComment.Text = "0 comments";
            picVideoThumb.Image = Properties.Resources.thumbnail_video;
            
            lblPub.Text = "";
            lblDimension.Visible = false;
            lblDefinition.Visible = false;
            lblDuration.Visible = false;
            btnReset.Enabled = false;
            lblCategory.Text = "Category: ";
            lblLoadStatus.Visible = false;
        }
        
        public frmVideo(string videoId)
        {
            InitializeComponent();
            if (IsInternetAvailable())
            {
                lblLoadStatus.Visible = true;

                txtboxSearch.Text = "https://wwww,youtube.com/watch?v=" + videoId;
                GetInfo(videoId);
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red100, TextShade.WHITE);
                lblVersion.Text = "Current version: " + Application.ProductVersion + " - Copyright © 2016 Anh Quoc Tran";

                lblLoadStatus.Visible = false;
            }
            else
            {
                MessageBox.Show("Can't connect to the Internet! Please try again!");
                Close();
            }
            
                      
        }

        protected string VideoUrl = "";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtboxSearch.Text;
            lblLoadStatus.Visible = true;
            if (input == "")
                MessageBox.Show("Do not empty textbox URL!");
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
                MessageBox.Show("YouTube URL or video ID is not correct!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblLoadStatus.Visible = false;
        }

        string ChannelId = "";

        private void GetInfo(string Id)
        {
            YoutubeVideo Video = new YoutubeVideo(Id);
            lblVideoTitle.Text = Video.Title;
            lblPub.Text = Video.ChannelTitle;
            lblDate.Text = "Published date: " + Video.DatePublished.Hour.ToString() + " hours " + Video.DatePublished.Month + " min " + Video.DatePublished.Second.ToString() + " sec - " + Video.DatePublished.Day.ToString() + "/" + Video.DatePublished.Month.ToString() + "/" + Video.DatePublished.Year.ToString();
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
                    lblCategory.Text = "Category: Film && Animation";
                    break;
                case "2":
                    lblCategory.Text = "Category: Xe && Phương tiện";
                    break;
                case "10":
                    lblCategory.Text = "Category: Music";
                    break;
                case "15":
                    lblCategory.Text = "Category: Pets && Animals";
                    break;
                case "17":
                    lblCategory.Text = "Category: Sports";
                    break;
                case "19":
                    lblCategory.Text = "Category: Travels && events";
                    break;
                case "20":
                    lblCategory.Text = "Category: Game";
                    break;
                case "22":
                    lblCategory.Text = "Category: People && Blogs";
                    break;
                case "23":
                    lblCategory.Text = "Category: Comedy";
                    break;
                case "24":
                    lblCategory.Text = "Category: Entertaintment";
                    break;
                case "25":
                    lblCategory.Text = "Category: News && Politics";
                    break;
                case "26":
                    lblCategory.Text = "Category: Style && Life";
                    break;
                case "27":
                    lblCategory.Text = "Category: Education";
                    break;
                case "28":
                    lblCategory.Text = "Category: Science && Technology";
                    break;
                case "29":
                    lblCategory.Text = "Category: Activties && Non-profits";
                    break;
                
                default: lblCategory.Text = "Category: Unknown";
                    break;
            }


            lblComment.Text = Video.CommentCount.Value.ToString("N0") + " comments";
            lblView.Text = Video.View.Value.ToString("N0") + " views";
            lblLikeDislike.Text = Video.Like.Value.ToString("N0") + " likes - " + Video.Dislike.Value.ToString("N0") + " dislikes";
            
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
            txtboxSearch.SelectAll();
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
            
        }

        private void lblPub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChannelInfo ci = new frmChannelInfo(ChannelId);
            
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
            lblDate.Text = "Published date: ";
            lblDescription.Text = "";
            lblLikeDislike.Text = "0 likes - 0 dislikes";
            lblPublisher.Text = "Publisher: ";
            lblVideoTitle.Text = "";
            lblView.Text = "0 views";
            lblComment.Text = "0 comments";
            picVideoThumb.Image = Properties.Resources.thumbnail_video;
            
            lblPub.Text = "";
            lblDimension.Visible = false;
            lblDefinition.Visible = false;
            lblDuration.Visible = false;
            txtboxSearch.Clear();
            lblCategory.Text = "Category: ";
            lblVideoTitle.Text = "We haven't received data...";
            rchtxtTags.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmHome(), "Backing to Home...");
            Initial.ShowDialog();
            this.Close();
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

        private void chkMin_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}

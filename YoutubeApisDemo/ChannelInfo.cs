using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeApisDemo
{
    public partial class ChannelInfo : Form
    {
        public ChannelInfo(string id)
        {
            InitializeComponent();           
            ChannelID = id;
            GetChannelInfo(ChannelID);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public delegate void SendChannelID(string Id);
        public SendChannelID getChannelId;

        public string ChannelID;

        
        private void GetChannelInfo(string Id)
        {
            YouTubeChannel channel = new YouTubeChannel(Id);
            lblChannelName.Text = channel.ChannelName;
            //lblCommentCounter.Text = channel.CommentCounter.Value.ToString("N0") + " bình luận";
            lblView.Text = channel.ViewCounter.Value.ToString("N0") + " lượt xem";
            lblVideoCounter.Text = channel.VideoCounter.Value.ToString("N0") + " video";
            btnSubscriberCounter.Text = channel.SubscribeCounter.Value.ToString("N0");
            picAvatar.ImageLocation = channel.AvatarUrl;

            if (channel.CoverPhotoUrl.Contains("default_banner"))
            {
                picBanner.Image = Properties.Resources.blackPanel;
            }
            else
            {
                picBanner.ImageLocation = channel.CoverPhotoUrl;
            }          
        }

        private void ChannelInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

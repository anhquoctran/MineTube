using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YoutubeApisDemo
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
            SendVideoUrl = new SendUrl(GetUrl);
            SendVideoTitle = new SendTitle(GetTitle);
            playerVideo.Play();
            
        }

        public delegate void SendUrl(string url);
        public SendUrl SendVideoUrl;

        public delegate void SendTitle(string title);
        public SendTitle SendVideoTitle;

        private void GetUrl(string url)
        {
            playerVideo.Movie = url;
        }

        private void GetTitle(string title)
        {
            this.Text = "YouTube API v3 Demo - " + title;
        }
    }
}

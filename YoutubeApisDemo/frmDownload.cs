using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using YoutubeExtractor;
using System.IO;

namespace YoutubeApisDemo
{
    public partial class frmDownload : MaterialForm
    {
        public frmDownload(string Url, string Name)
        {
            InitializeComponent();
            
            VideoURL = Url;
            lblVideoName.Text = Name;

            saveVideo.InitialDirectory = defaultPath;
            

            lblVideoSize.Text = "n/a";
            lblStatus.Text = "Ready to download";
            cbFormat.SelectedIndex = 2;
            cbQuality.SelectedIndex = 2;
            saveVideo.Filter = "MPEG-4 Video (*.mp4)|*.mp4|Flash Video (*.flv)|*.flv|HTML5 Video Format (*.webm)|*.webm|Video for Mobile Device (*.3gpp)|*.3gpp";
            saveVideo.DefaultExt = "MPEG-4 Video (*.mp4)|*.mp4";
            lblsavePath.Text = defaultPath + Name + cbFormat.SelectedItem.ToString();

            saveVideo.FileName = defaultPath + Name;

            
        }

        string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        string VideoURL = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveResult = saveVideo.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                lblsavePath.Text = saveVideo.FileName;
            }
            
        }

        private void bwDownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbDownloadStatus.Value = e.ProgressPercentage;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            btnDownload.Text = "Stop";
            IEnumerable<VideoInfo> infos = DownloadUrlResolver.GetDownloadUrls(VideoURL);
            VideoInfo video = infos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
            
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            var videoDownloader = new VideoDownloader(video, Path.Combine("D:/", video.Title +video.VideoExtension));

            videoDownloader.DownloadProgressChanged += VideoDownloader_DownloadProgressChanged;
            
            videoDownloader.Execute();           
        }
       
        private void VideoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            lblStatus.Text = "Downloading " + e.ProgressPercentage.ToString() + " %";
        }

        private void notifyDownload_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyDownload.Visible = false;
            this.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyDownload.ShowBalloonTip(1000);
            notifyDownload.Visible = true;
            notifyDownload.BalloonTipTitle = "Your video is downloading...";
            notifyDownload.BalloonTipText = "Click to restore";
        }
    }
}

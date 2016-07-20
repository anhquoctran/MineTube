using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MineTube.Controls
{
    public partial class Downloader : UserControl
    {
        #region Properties and Fields
        /// <summary>
        /// Gets or sets YouTube URL Video.
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// Gets YouTube Download URL.
        /// </summary>
        public string DownloadURL { get; private set; }
        /// <summary>
        /// Gets or sets location (file path) to save video after downloaded.
        /// </summary>
        public string SaveAs { get; set; }
        /// <summary>
        /// Gets all available quality of video.
        /// </summary>
        public List<string> Quality { get; private set; }
        /// <summary>
        /// Gets all available size in bytes of current video.
        /// </summary>
        public string FileSize { get; private set; }
        /// <summary>
        /// Gets current download speed.
        /// </summary>
        public string Speed { get; private set; }
        /// <summary>
        /// Gets status of current process and represent in String.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Size of this Control is read-only and cannot change.
        /// </summary>
        public new Size Size { get; private set; }
        /// <summary>
        /// Gets name of current video.
        /// </summary>
        public string VideoName { get; private set; }
        string filename = "download.png";
        #endregion

        #region Contructors
        
        /// <summary>
        /// Initializing a new Downloader Control.
        /// </summary>
        /// <param name="VideoURL">URL of YouTube video</param>
        public Downloader(string VideoURL = "")
        {
            InitializeComponent();
            InitializeControl();
        }

        public Downloader()
        {
            InitializeComponent();
            InitializeControl();
        }
        #endregion

        #region Methods used
        private void InitializeControl()
        {
            Size = new Size(609, 319);
            BackColor = Color.White;
            lblPath.Text = SaveAs;
            lblURL.Text = URL;
            lblSpeed.Text = Speed;
            lblSize.Text = FileSize;
            lblVideoName.Text = VideoName;
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }
        
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void cbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bwDonwload_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bwDonwload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bwDonwload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion

    }
}

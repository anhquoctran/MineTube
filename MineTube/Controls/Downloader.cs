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

        //Fields
        private string videoUrl = "";
        private string FileLocation = "";
        private List<string> DownloadUri;
        private List<string> videoQual;    
        private byte buffers;
        private byte[] bytesReceiced;
        private byte fileSizeInByte;

        //Properties
        /// <summary>
        /// Gets or sets YouTube URL Video.
        /// </summary>
        public string URL
        {
            get
            {
                return lblURL.Text;
            }
            set
            {
                lblURL.Text = value;
            }
        }
        /// <summary>
        /// Gets YouTube Download URL.
        /// </summary>
        public string DownloadURL
        {
            get
            {
                return lblURL.Text;
            }
            private set
            {
                lblURL.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets location (file path) to save video after downloaded.
        /// </summary>
        public string SaveAs
        {
            get
            {
                return lblPath.Text;
            }
            set
            {
                lblPath.Text = value;
            }
        }
        /// <summary>
        /// Gets all available quality of video.
        /// </summary>
        public ComboBox.ObjectCollection Quality
        {
            get
            {
                ComboBox.ObjectCollection temp = new ComboBox.ObjectCollection(cbQuality);
                for (int i = 0; i < cbQuality.Items.Count; i++)
                {
                    string value = cbQuality.GetItemText(cbQuality.Items[i]);
                    temp.Add(value);
                }
                return temp;
            }
            private set
            {
                cbQuality.Items.Add(value);
            }
        }

        /// <summary>
        /// Gets all available size in bytes of current video.
        /// </summary>
        public string FileSize
        {
            get
            {
                return lblSize.Text;
            }
            private set
            {
                lblSize.Text = value;
            }
        }
        /// <summary>
        /// Gets current download speed.
        /// </summary>
        private string Speed
        {
            get
            {
                return lblSpeed.Text;
            }
            set
            {
                lblSpeed.Text = value;
            }
        }
        /// <summary>
        /// Gets status of current process and represent in String.
        /// </summary>
        private string Status
        {
            get
            {
                return lblStatus.Text;
            }
            set
            {
                lblStatus.Text = value;
            }
        }
        /// <summary>
        /// Gets name of current video.
        /// </summary>
        private string VideoName
        {
            get
            {
                return lblVideoName.Text;
            }
            set
            {
                lblVideoName.Text = value;
            }
        }
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
            BackColor = Color.White;
            lblPath.Text = "Your file path will be place in here...";
            lblURL.Text = URL;
            lblSpeed.Text = Speed;
            lblSize.Text = FileSize;
            lblVideoName.Text = VideoName;
            lblStatus.Text = Status;
            
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

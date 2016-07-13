using MaterialSkin.Controls;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            lblStatus.Text = "";
            cbFormat.SelectedIndex = 2;
            cbQuality.SelectedIndex = 2;
            saveVideo.Filter = "MPEG-4 Video (*.mp4)|*.mp4|Flash Video (*.flv)|*.flv|HTML5 Video Format (*.webm)|*.webm|Video for Mobile Device (*.3gpp)|*.3gpp";
            saveVideo.DefaultExt = "MPEG-4 Video (*.mp4)|*.mp4";
            lblsavePath.Text = defaultPath + "\\" + Name + "." + cbFormat.SelectedItem.ToString().ToLower();

            saveVideo.FileName = Path.GetFileNameWithoutExtension(lblsavePath.Text);       
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            pbStatus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            btnDownload.Enabled = false;
            pbStatus.Properties.Step = 1;
            pbStatus.Properties.PercentView = false;
            pbStatus.Properties.Maximum = 512160;
            lblStatus.Visible = true;
            lblStatus.Text = "Processing...";
            for (int i = 0; i < pbStatus.Properties.Maximum; i++)
            {
                pbStatus.Properties.DisplayFormat.FormatString = "Fetching... " + pbStatus.Position.ToString() + "/" + pbStatus.Properties.Maximum.ToString() + " bytes";
                pbStatus.PerformStep();
                pbStatus.Update();
            }
        }

        private void notifyDownload_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyDownload.Visible = false;
            this.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyDownload.ShowBalloonTip(2500);
            notifyDownload.Visible = true;
            notifyDownload.BalloonTipTitle = "Your video is downloading...";
            notifyDownload.BalloonTipText = "Click to restore";
        }

        private static string RemoveIllegalPathCharacters(string path)
        { 
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void notifyDownload_Click(object sender, EventArgs e)
        {
            //contextNotify.Show(notifyDownload, new Point(notifyDownload.))
        }
    }
}

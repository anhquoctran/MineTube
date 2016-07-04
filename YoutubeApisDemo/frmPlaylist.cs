using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Runtime.InteropServices;

namespace YoutubeApisDemo
{
    public partial class frmPlaylist : Form
    {
        public frmPlaylist()
        {
            InitializeComponent();
            //TitleCol = new ColumnHeader();
            //UrlCol = new ColumnHeader();
            //DurationCol = new ColumnHeader();
            //PublishedDateCol = new ColumnHeader();
            //lstVideos.Columns.AddRange(new ColumnHeader[] { TitleCol, DurationCol, PublishedDateCol, UrlCol});
            //TitleCol.Text = "Title";
            //UrlCol.Text = "URL";
            //DurationCol.Text = "Duration";
            //PublishedDateCol.Text = "Date Published";
            //piIcon.Image = Icon.ToBitmap();
            //lblTitle.Text = Text;
            prbStatus.Visible = false;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //ColumnHeader TitleCol;
        //ColumnHeader UrlCol;
        //ColumnHeader DurationCol;
        //ColumnHeader PublishedDateCol;

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetPlaylistInfo(txtboxUrl.Text);
        }

        private void GetPlaylistInfo(string inputId)
        {
            

            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", "Error");
            }
            else
            {
                YoutubeVideo[] videos = YoutubeApis.GetPlaylistInfo(inputId);
                DataTable dtVdideos = new DataTable();
                
                foreach (var video in videos)
                {
                    
                    
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

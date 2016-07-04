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

namespace YoutubeApisDemo
{
    public partial class frmPlaylist : Form
    {
        public frmPlaylist()
        {
            InitializeComponent();
            lblTitle.Text = Text;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetPlaylistInfo(txtboxUrl.Text);
        }

        private void GetPlaylistInfo(string inputId)
        {
            lstVideo.Items.Clear();

            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", "Error");
            }
            else
            {
                YoutubeVideo[] videos = YoutubeApis.GetPlaylistInfo("");
                foreach (var video in videos)
                {
                    lstVideo.Items.Add(video.Duration + " - " + video.Title);
                }
            }
            //}

            //if (inputId.Contains("https://youtu.be/"))
            //{

            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            Close();
        }

        //OLVColumn ThumbCol;
        //OLVColumn InfoCol;
    }
}

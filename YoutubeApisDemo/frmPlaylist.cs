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
using MaterialSkin;
using MaterialSkin.Controls;

namespace YoutubeApisDemo
{
    public partial class frmPlaylist : MaterialForm
    {
        public frmPlaylist()
        {
            InitializeComponent();
            
            prbStatus.Visible = false;
        }
        

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }
    }
}

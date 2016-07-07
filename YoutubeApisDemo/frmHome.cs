using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net;

namespace YoutubeApisDemo
{
    public partial class frmHome : MaterialForm
    {
        public frmHome()
        {
            
            //load.ShowDialog();
            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green300, Accent.Green100, TextShade.WHITE);
            
            if (IsConnected() == true)
            {
                lblNetworkStatus.Text = "Connected to YouTube Services";
                lblMess.Text = "Choose features which you want to use";
                MenuConnect.Visible = false;
                lblNetworkStatus.ForeColor = Color.Green;
                btnPlaylist.Enabled = true;
                btnSearch.Enabled = true;
                btnVideoInfo.Enabled = true;
            }
            else
            {
                lblNetworkStatus.Text = "Connection is lost! Check connection and press F5 to reconnect";
                lblMess.Text = "You're not connected. Please check your Internet connection";
                lblNetworkStatus.ForeColor = Color.Red;
                MenuConnect.Visible = true;
                btnPlaylist.Enabled = false;
                btnSearch.Enabled = false;
                btnVideoInfo.Enabled = false;
            }

            lblSoftversion.Text = "Current version: " + Application.ProductVersion + " - Copyright © 2016 Anh Quoc Tran";
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static bool IsConnected()
        {
            var res = false;

            try
            {
                using(var client = new WebClient())
                {
                    using (var stream = client.OpenRead("https://www.youtube.com"))
                    {
                        res = true;
                    }
                }               
            }
            catch (Exception)
            {
                res = false;
            }

            return res;
        }

        private void btnVideoInfo_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmVideo());
            Initial.ShowDialog();
            
        }
       
        private void btnChannel_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmPlaylist());
            Initial.ShowDialog();
            this.Close();
            
            
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmSearch());
            Initial.ShowDialog();
            this.Close();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void refreshConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsConnected() == true)
            {
                lblNetworkStatus.Text = "Connected to YouTube Services";
                lblMess.Text = "Choose features which you want to use";
                MenuConnect.Visible = false;
                lblNetworkStatus.ForeColor = Color.Green;
                btnPlaylist.Enabled = true;
                btnSearch.Enabled = true;
                btnVideoInfo.Enabled = true;
            }
            else
            {
                lblNetworkStatus.Text = "Connection is lost! Check connection and press F5 to reconnect";
                lblMess.Text = "You're not connected. Please check your Internet connection";
                MenuConnect.Visible = false;
                lblNetworkStatus.ForeColor = Color.Red;
                btnPlaylist.Enabled = false;
                btnSearch.Enabled = false;
                btnVideoInfo.Enabled = false;
            }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
using System.Runtime.InteropServices;

namespace MineTube
{
    public partial class frmSearch : MaterialForm
    {
        public frmSearch()
        {
            InitializeComponent();
            lblVersion.Text = "Current version: " + Application.ProductVersion + " - Copyright © 2016 Anh Quoc Tran";
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            //prbStatus.Visible = false;
            radioBtnVideo.Checked = true;           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmHome(), "Backing to Home...");
            Initial.ShowDialog();
            
            this.Close();
        }

        private void radioBtnVideo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void prbStatus_Click(object sender, EventArgs e)
        {

        }
    }
}

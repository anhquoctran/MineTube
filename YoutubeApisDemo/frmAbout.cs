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

namespace YoutubeApisDemo
{
    public partial class frmAbout : MaterialForm
    {
        public frmAbout()
        {
            InitializeComponent();
            lblAuthor.Text = "Anh Quoc Tran";
            lblVersion.Text = Application.ProductVersion;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmAbout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

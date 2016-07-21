using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;

namespace MineTube
{
    public partial class frmAbout : MaterialForm
    {
        public frmAbout()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red100, TextShade.WHITE);            
            lblCopyright.Text = "Copyright © " + DateTime.Now.Year.ToString() + ". All rights reserved.";
            lblAuthor.Text = "Developer: Anh Quoc Tran";
            lblVersion.Text = "Version: " + Application.ProductVersion;
        }

        
        private void frmAbout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picDonation_Click(object sender, EventArgs e)
        {
            string PaypalUrl = "";
            string Business = "aquoc.hue@outlook.com";
            string Description = "Donation for MineTube";
            string Country = "VN";
            string Currency = "USD";

            PaypalUrl += "https://www.paypal.com/cgi-bin/webscr" + "?cmd=" + "_donations" + "&business=" + Business + "&lc=" + Country + "&item_name=" + Description + "&currency_code=" + Currency + "&bn=" + "PP%2dDonationsBF";
            Process.Start(PaypalUrl);
        }
    }
}

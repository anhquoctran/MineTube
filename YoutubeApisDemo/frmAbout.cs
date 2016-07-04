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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MineTube
{
    public partial class frmPreferences : MaterialForm
    {
        public frmPreferences()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmInitializers Initial = new frmInitializers(new frmHome(), "Backing to Home...");
            Initial.ShowDialog();
            Close();
        }
    }
}

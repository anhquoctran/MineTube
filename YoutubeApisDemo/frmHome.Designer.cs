namespace YoutubeApisDemo
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblMess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSoftversion = new System.Windows.Forms.Label();
            this.btnVideoInfo = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lblNetworkStatus = new System.Windows.Forms.Label();
            this.MenuConnect = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.refreshConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to\r\nYouTube Data API Demo Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(429, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Playlist Info";
            this.toolTip1.SetToolTip(this.label2, "Get Playlist Information");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(706, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Info";
            this.toolTip1.SetToolTip(this.label3, "Get Video Information");
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Depth = 0;
            this.btnAbout.Location = new System.Drawing.Point(813, 592);
            this.btnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Primary = true;
            this.btnAbout.Size = new System.Drawing.Size(125, 42);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblMess
            // 
            this.lblMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMess.ContextMenuStrip = this.MenuConnect;
            this.lblMess.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMess.ForeColor = System.Drawing.Color.DimGray;
            this.lblMess.Location = new System.Drawing.Point(12, 283);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(926, 26);
            this.lblMess.TabIndex = 9;
            this.lblMess.Text = "Choose features which you want to use\r\n";
            this.lblMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(179, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search";
            this.toolTip1.SetToolTip(this.label4, "Search");
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(122, 326);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 172);
            this.btnSearch.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSoftversion
            // 
            this.lblSoftversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoftversion.AutoSize = true;
            this.lblSoftversion.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftversion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoftversion.ForeColor = System.Drawing.Color.Gray;
            this.lblSoftversion.Location = new System.Drawing.Point(12, 620);
            this.lblSoftversion.Name = "lblSoftversion";
            this.lblSoftversion.Size = new System.Drawing.Size(64, 13);
            this.lblSoftversion.TabIndex = 6;
            this.lblSoftversion.Text = "softversion";
            // 
            // btnVideoInfo
            // 
            this.btnVideoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideoInfo.FlatAppearance.BorderSize = 0;
            this.btnVideoInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnVideoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideoInfo.Image")));
            this.btnVideoInfo.Location = new System.Drawing.Point(650, 326);
            this.btnVideoInfo.Name = "btnVideoInfo";
            this.btnVideoInfo.Size = new System.Drawing.Size(198, 172);
            this.btnVideoInfo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnVideoInfo, "Get Video Information");
            this.btnVideoInfo.UseVisualStyleBackColor = true;
            this.btnVideoInfo.Click += new System.EventHandler(this.btnVideoInfo_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.Location = new System.Drawing.Point(378, 326);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(176, 172);
            this.btnPlaylist.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPlaylist, "Get Playlist Information");
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnChannel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(926, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "UI by Google Material Design™";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetworkStatus
            // 
            this.lblNetworkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNetworkStatus.AutoSize = true;
            this.lblNetworkStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblNetworkStatus.ContextMenuStrip = this.MenuConnect;
            this.lblNetworkStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNetworkStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblNetworkStatus.Location = new System.Drawing.Point(12, 607);
            this.lblNetworkStatus.Name = "lblNetworkStatus";
            this.lblNetworkStatus.Size = new System.Drawing.Size(55, 13);
            this.lblNetworkStatus.TabIndex = 13;
            this.lblNetworkStatus.Text = "netstatus";
            // 
            // MenuConnect
            // 
            this.MenuConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MenuConnect.Depth = 0;
            this.MenuConnect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshConnectionToolStripMenuItem});
            this.MenuConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenuConnect.Name = "MenuConnect";
            this.MenuConnect.Size = new System.Drawing.Size(172, 26);
            // 
            // refreshConnectionToolStripMenuItem
            // 
            this.refreshConnectionToolStripMenuItem.Name = "refreshConnectionToolStripMenuItem";
            this.refreshConnectionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshConnectionToolStripMenuItem.ShowShortcutKeys = false;
            this.refreshConnectionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refreshConnectionToolStripMenuItem.Text = "Refresh Connection";
            this.refreshConnectionToolStripMenuItem.Click += new System.EventHandler(this.refreshConnectionToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 645);
            this.ContextMenuStrip = this.MenuConnect;
            this.Controls.Add(this.lblNetworkStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVideoInfo);
            this.Controls.Add(this.lblMess);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblSoftversion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.MenuConnect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnVideoInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblSoftversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMess;
        private MaterialSkin.Controls.MaterialRaisedButton btnAbout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNetworkStatus;
        private MaterialSkin.Controls.MaterialContextMenuStrip MenuConnect;
        private System.Windows.Forms.ToolStripMenuItem refreshConnectionToolStripMenuItem;
    }
}
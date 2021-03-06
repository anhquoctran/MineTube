﻿namespace MineTube
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
            this.MenuConnect = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.refreshConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoftversion = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lblNetworkStatus = new System.Windows.Forms.Label();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnVideoInfo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.picAvatarUser = new MineTube.Controls.CirclePictureBox();
            this.MenuConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1077, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MineTube™";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(320, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Playlist Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "Get Playlist Information");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(573, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Info";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label3, "Get Video Information");
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Depth = 0;
            this.btnAbout.Location = new System.Drawing.Point(967, 650);
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
            this.lblMess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMess.ContextMenuStrip = this.MenuConnect;
            this.lblMess.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMess.ForeColor = System.Drawing.Color.DimGray;
            this.lblMess.Location = new System.Drawing.Point(12, 264);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(1080, 44);
            this.lblMess.TabIndex = 9;
            this.lblMess.Text = "Select which you want to use";
            this.lblMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MenuConnect.Opening += new System.ComponentModel.CancelEventHandler(this.MenuConnect_Opening);
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(69, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "Search");
            // 
            // lblSoftversion
            // 
            this.lblSoftversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoftversion.AutoSize = true;
            this.lblSoftversion.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftversion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoftversion.ForeColor = System.Drawing.Color.Gray;
            this.lblSoftversion.Location = new System.Drawing.Point(12, 678);
            this.lblSoftversion.Name = "lblSoftversion";
            this.lblSoftversion.Size = new System.Drawing.Size(64, 13);
            this.lblSoftversion.TabIndex = 6;
            this.lblSoftversion.Text = "softversion";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1080, 22);
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
            this.lblNetworkStatus.Location = new System.Drawing.Point(12, 665);
            this.lblNetworkStatus.Name = "lblNetworkStatus";
            this.lblNetworkStatus.Size = new System.Drawing.Size(55, 13);
            this.lblNetworkStatus.TabIndex = 13;
            this.lblNetworkStatus.Text = "netstatus";
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.Location = new System.Drawing.Point(320, 338);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(176, 172);
            this.btnPlaylist.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPlaylist, "Get Playlist Information");
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnChannel_Click);
            // 
            // btnVideoInfo
            // 
            this.btnVideoInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVideoInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideoInfo.FlatAppearance.BorderSize = 0;
            this.btnVideoInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnVideoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideoInfo.Image")));
            this.btnVideoInfo.Location = new System.Drawing.Point(573, 338);
            this.btnVideoInfo.Name = "btnVideoInfo";
            this.btnVideoInfo.Size = new System.Drawing.Size(198, 172);
            this.btnVideoInfo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnVideoInfo, "Get Video Information");
            this.btnVideoInfo.UseVisualStyleBackColor = true;
            this.btnVideoInfo.Click += new System.EventHandler(this.btnVideoInfo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(69, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 172);
            this.btnSearch.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(839, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Preferences";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label5, "Preferences");
            // 
            // btnPreferences
            // 
            this.btnPreferences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreferences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreferences.FlatAppearance.BorderSize = 0;
            this.btnPreferences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferences.Image = ((System.Drawing.Image)(resources.GetObject("btnPreferences.Image")));
            this.btnPreferences.Location = new System.Drawing.Point(839, 338);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(198, 172);
            this.btnPreferences.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnPreferences, "Preferences");
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // picAvatarUser
            // 
            this.picAvatarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAvatarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatarUser.Image = global::MineTube.Properties.Resources.null_avatar;
            this.picAvatarUser.Location = new System.Drawing.Point(1050, 28);
            this.picAvatarUser.Name = "picAvatarUser";
            this.picAvatarUser.Size = new System.Drawing.Size(32, 32);
            this.picAvatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarUser.TabIndex = 15;
            this.picAvatarUser.TabStop = false;
            this.toolTip1.SetToolTip(this.picAvatarUser, "Google Account");
            this.picAvatarUser.Click += new System.EventHandler(this.picAvatarUser_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 703);
            this.ContextMenuStrip = this.MenuConnect;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.picAvatarUser);
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
            this.MinimumSize = new System.Drawing.Size(869, 579);
            this.Name = "frmHome";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.MenuConnect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).EndInit();
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
        private Controls.CirclePictureBox picAvatarUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPreferences;
    }
}
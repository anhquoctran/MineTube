namespace YoutubeApisDemo
{
    partial class frmDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownload));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVideoName = new System.Windows.Forms.Label();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.lblsavePath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVideoSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.saveVideo = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.notifyDownload = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextNotify = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDownload = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHide = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbStatus = new DevExpress.XtraEditors.ProgressBarControl();
            this.contextNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Video name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quality:";
            // 
            // lblVideoName
            // 
            this.lblVideoName.AutoSize = true;
            this.lblVideoName.BackColor = System.Drawing.Color.White;
            this.lblVideoName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVideoName.Location = new System.Drawing.Point(102, 133);
            this.lblVideoName.Name = "lblVideoName";
            this.lblVideoName.Size = new System.Drawing.Size(72, 17);
            this.lblVideoName.TabIndex = 4;
            this.lblVideoName.Text = "videoName";
            // 
            // cbQuality
            // 
            this.cbQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Items.AddRange(new object[] {
            "240p",
            "360p",
            "480p",
            "720p",
            "1080p"});
            this.cbQuality.Location = new System.Drawing.Point(105, 218);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(130, 23);
            this.cbQuality.TabIndex = 5;
            // 
            // lblsavePath
            // 
            this.lblsavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsavePath.AutoEllipsis = true;
            this.lblsavePath.BackColor = System.Drawing.Color.White;
            this.lblsavePath.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblsavePath.ForeColor = System.Drawing.Color.Silver;
            this.lblsavePath.Location = new System.Drawing.Point(105, 91);
            this.lblsavePath.Name = "lblsavePath";
            this.lblsavePath.Size = new System.Drawing.Size(405, 22);
            this.lblsavePath.TabIndex = 6;
            this.lblsavePath.Text = "savePath";
            this.lblsavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size:";
            // 
            // lblVideoSize
            // 
            this.lblVideoSize.AutoSize = true;
            this.lblVideoSize.BackColor = System.Drawing.Color.White;
            this.lblVideoSize.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVideoSize.Location = new System.Drawing.Point(102, 160);
            this.lblVideoSize.Name = "lblVideoSize";
            this.lblVideoSize.Size = new System.Drawing.Size(62, 17);
            this.lblVideoSize.TabIndex = 9;
            this.lblVideoSize.Text = "videoSize";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Video format:";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "Flash",
            "Mobile",
            "MP4",
            "WebM"});
            this.cbFormat.Location = new System.Drawing.Point(105, 189);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(131, 23);
            this.cbFormat.TabIndex = 12;
            // 
            // saveVideo
            // 
            this.saveVideo.RestoreDirectory = true;
            this.saveVideo.Title = "Save video as";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(517, 85);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(67, 36);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save as";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // notifyDownload
            // 
            this.notifyDownload.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyDownload.ContextMenuStrip = this.contextNotify;
            this.notifyDownload.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyDownload.Icon")));
            this.notifyDownload.Click += new System.EventHandler(this.notifyDownload_Click);
            this.notifyDownload.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyDownload_MouseDoubleClick);
            // 
            // contextNotify
            // 
            this.contextNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextNotify.Depth = 0;
            this.contextNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.pauseDownloadToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.contextNotify.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextNotify.Name = "contextNotify";
            this.contextNotify.Size = new System.Drawing.Size(114, 98);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // pauseDownloadToolStripMenuItem
            // 
            this.pauseDownloadToolStripMenuItem.Name = "pauseDownloadToolStripMenuItem";
            this.pauseDownloadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pauseDownloadToolStripMenuItem.Text = "Pause";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.Location = new System.Drawing.Point(497, 312);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = false;
            this.btnDownload.Size = new System.Drawing.Size(87, 36);
            this.btnDownload.TabIndex = 18;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnHide
            // 
            this.btnHide.AutoSize = true;
            this.btnHide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHide.Depth = 0;
            this.btnHide.Location = new System.Drawing.Point(447, 312);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHide.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHide.Name = "btnHide";
            this.btnHide.Primary = false;
            this.btnHide.Size = new System.Drawing.Size(42, 36);
            this.btnHide.TabIndex = 19;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 259);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 15);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "label6";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(12, 277);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.pbStatus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pbStatus.Properties.ShowTitle = true;
            this.pbStatus.Size = new System.Drawing.Size(573, 16);
            this.pbStatus.TabIndex = 21;
            // 
            // frmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 363);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVideoSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsavePath);
            this.Controls.Add(this.cbQuality);
            this.Controls.Add(this.lblVideoName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 433);
            this.Name = "frmDownload";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download video";
            this.contextNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVideoName;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.Label lblsavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVideoSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.SaveFileDialog saveVideo;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private System.Windows.Forms.NotifyIcon notifyDownload;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextNotify;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton btnDownload;
        private MaterialSkin.Controls.MaterialFlatButton btnHide;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraEditors.ProgressBarControl pbStatus;
    }
}
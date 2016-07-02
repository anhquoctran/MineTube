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
            this.btnChannel = new System.Windows.Forms.Button();
            this.btnVideoInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSoftversion = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 139);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to\r\nYouTube API Demo Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnChannel
            // 
            this.btnChannel.FlatAppearance.BorderSize = 0;
            this.btnChannel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChannel.Image = ((System.Drawing.Image)(resources.GetObject("btnChannel.Image")));
            this.btnChannel.Location = new System.Drawing.Point(184, 187);
            this.btnChannel.Name = "btnChannel";
            this.btnChannel.Size = new System.Drawing.Size(150, 152);
            this.btnChannel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnChannel, "Get Playlist Information");
            this.btnChannel.UseVisualStyleBackColor = true;
            this.btnChannel.Click += new System.EventHandler(this.btnChannel_Click);
            // 
            // btnVideoInfo
            // 
            this.btnVideoInfo.FlatAppearance.BorderSize = 0;
            this.btnVideoInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVideoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideoInfo.Image")));
            this.btnVideoInfo.Location = new System.Drawing.Point(432, 187);
            this.btnVideoInfo.Name = "btnVideoInfo";
            this.btnVideoInfo.Size = new System.Drawing.Size(150, 152);
            this.btnVideoInfo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnVideoInfo, "Get Video Information");
            this.btnVideoInfo.UseVisualStyleBackColor = true;
            this.btnVideoInfo.Click += new System.EventHandler(this.btnVideoInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClose.Location = new System.Drawing.Point(668, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnClose, "Exit Application");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(211, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Playlist Info";
            this.toolTip1.SetToolTip(this.label2, "Get Playlist Information");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(470, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Info";
            this.toolTip1.SetToolTip(this.label3, "Get Video Information");
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblSoftversion);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.btnVideoInfo);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.btnChannel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(759, 462);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // lblSoftversion
            // 
            this.lblSoftversion.AutoSize = true;
            this.lblSoftversion.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftversion.ForeColor = System.Drawing.Color.Gray;
            this.lblSoftversion.Location = new System.Drawing.Point(11, 437);
            this.lblSoftversion.Name = "lblSoftversion";
            this.lblSoftversion.Size = new System.Drawing.Size(65, 15);
            this.lblSoftversion.TabIndex = 6;
            this.lblSoftversion.Text = "softversion";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmHome_MouseDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChannel;
        private System.Windows.Forms.Button btnVideoInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblSoftversion;
    }
}
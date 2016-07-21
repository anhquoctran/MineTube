namespace MineTube
{
    partial class frmChannelInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChannelInfo));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picAvatar = new Controls.CirclePictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.btnSubscriberCounter = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCommentCounter = new System.Windows.Forms.Label();
            this.lblVideoCounter = new System.Windows.Forms.Label();
            this.lblChannelName = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.picAvatar);
            this.pnlMain.Controls.Add(this.close);
            this.pnlMain.Controls.Add(this.btnSubscriberCounter);
            this.pnlMain.Controls.Add(this.lblView);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.lblCommentCounter);
            this.pnlMain.Controls.Add(this.lblVideoCounter);
            this.pnlMain.Controls.Add(this.lblChannelName);
            this.pnlMain.Controls.Add(this.picBanner);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(530, 203);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAvatar.Image = global::MineTube.Properties.Resources.f3;
            this.picAvatar.Location = new System.Drawing.Point(21, 41);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(100, 100);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 11;
            this.picAvatar.TabStop = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(502, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 15);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 10;
            this.close.TabStop = false;
            this.toolTip1.SetToolTip(this.close, "Đóng");
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnSubscriberCounter
            // 
            this.btnSubscriberCounter.BackColor = System.Drawing.Color.Transparent;
            this.btnSubscriberCounter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubscriberCounter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubscriberCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscriberCounter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubscriberCounter.ForeColor = System.Drawing.Color.Silver;
            this.btnSubscriberCounter.Location = new System.Drawing.Point(206, 119);
            this.btnSubscriberCounter.Name = "btnSubscriberCounter";
            this.btnSubscriberCounter.Size = new System.Drawing.Size(85, 22);
            this.btnSubscriberCounter.TabIndex = 9;
            this.btnSubscriberCounter.TabStop = false;
            this.btnSubscriberCounter.Text = "0";
            this.btnSubscriberCounter.UseVisualStyleBackColor = false;
            // 
            // lblView
            // 
            this.lblView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblView.AutoSize = true;
            this.lblView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblView.ForeColor = System.Drawing.Color.Gray;
            this.lblView.Location = new System.Drawing.Point(391, 170);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(69, 17);
            this.lblView.TabIndex = 8;
            this.lblView.Text = "0 lượt xems";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(132, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Subscribers";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblCommentCounter
            // 
            this.lblCommentCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCommentCounter.AutoSize = true;
            this.lblCommentCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommentCounter.ForeColor = System.Drawing.Color.Gray;
            this.lblCommentCounter.Location = new System.Drawing.Point(21, 170);
            this.lblCommentCounter.Name = "lblCommentCounter";
            this.lblCommentCounter.Size = new System.Drawing.Size(75, 17);
            this.lblCommentCounter.TabIndex = 5;
            this.lblCommentCounter.Text = "0 comments";
            // 
            // lblVideoCounter
            // 
            this.lblVideoCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoCounter.AutoSize = true;
            this.lblVideoCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVideoCounter.ForeColor = System.Drawing.Color.Gray;
            this.lblVideoCounter.Location = new System.Drawing.Point(219, 170);
            this.lblVideoCounter.Name = "lblVideoCounter";
            this.lblVideoCounter.Size = new System.Drawing.Size(52, 17);
            this.lblVideoCounter.TabIndex = 4;
            this.lblVideoCounter.Text = "0 videos";
            this.lblVideoCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChannelName
            // 
            this.lblChannelName.AutoEllipsis = true;
            this.lblChannelName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannelName.Location = new System.Drawing.Point(127, 91);
            this.lblChannelName.Name = "lblChannelName";
            this.lblChannelName.Size = new System.Drawing.Size(390, 25);
            this.lblChannelName.TabIndex = 2;
            this.lblChannelName.Text = "Channel name";
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBanner.Image = global::MineTube.Properties.Resources.blackPanel;
            this.picBanner.InitialImage = global::MineTube.Properties.Resources.blackPanel;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(528, 88);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // frmChannelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 203);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChannelInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Channel Info";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChannelInfo_MouseDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblChannelName;
        private System.Windows.Forms.Label lblCommentCounter;
        private System.Windows.Forms.Label lblVideoCounter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubscriberCounter;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.PictureBox close;
        private Controls.CirclePictureBox picAvatar;
    }
}
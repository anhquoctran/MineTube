namespace YoutubeApisDemo
{
    partial class frmPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaylist));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnGet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtboxUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.prbStatus = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.frmPlaylistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listVideo = new MaterialSkin.Controls.MaterialListView();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPlaylistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.prbStatus);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.txtboxUrl);
            this.pnlMain.Controls.Add(this.btnGet);
            this.pnlMain.Controls.Add(this.listVideo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(732, 645);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Depth = 0;
            this.btnGet.Location = new System.Drawing.Point(605, 11);
            this.btnGet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGet.Name = "btnGet";
            this.btnGet.Primary = true;
            this.btnGet.Size = new System.Drawing.Size(114, 41);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Grab now!";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtboxUrl
            // 
            this.txtboxUrl.Depth = 0;
            this.txtboxUrl.Hint = "Enter YouTube playlist URL...";
            this.txtboxUrl.Location = new System.Drawing.Point(15, 29);
            this.txtboxUrl.MaxLength = 32767;
            this.txtboxUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxUrl.Name = "txtboxUrl";
            this.txtboxUrl.PasswordChar = '\0';
            this.txtboxUrl.SelectedText = "";
            this.txtboxUrl.SelectionLength = 0;
            this.txtboxUrl.SelectionStart = 0;
            this.txtboxUrl.Size = new System.Drawing.Size(584, 23);
            this.txtboxUrl.TabIndex = 8;
            this.txtboxUrl.TabStop = false;
            this.txtboxUrl.UseSystemPasswordChar = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(11, 309);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(708, 29);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "There are nothing to display";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prbStatus
            // 
            this.prbStatus.Depth = 0;
            this.prbStatus.Location = new System.Drawing.Point(228, 341);
            this.prbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(271, 5);
            this.prbStatus.Step = 1;
            this.prbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prbStatus.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(605, 591);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(114, 41);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Go Home";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmPlaylistBindingSource
            // 
            this.frmPlaylistBindingSource.DataSource = typeof(YoutubeApisDemo.frmPlaylist);
            // 
            // listVideo
            // 
            this.listVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVideo.Depth = 0;
            this.listVideo.Font = new System.Drawing.Font("Roboto", 24F);
            this.listVideo.FullRowSelect = true;
            this.listVideo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVideo.Location = new System.Drawing.Point(15, 58);
            this.listVideo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listVideo.MouseState = MaterialSkin.MouseState.OUT;
            this.listVideo.Name = "listVideo";
            this.listVideo.OwnerDraw = true;
            this.listVideo.Size = new System.Drawing.Size(704, 527);
            this.listVideo.TabIndex = 12;
            this.listVideo.TileSize = new System.Drawing.Size(64, 64);
            this.listVideo.UseCompatibleStateImageBehavior = false;
            this.listVideo.View = System.Windows.Forms.View.Details;
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 645);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YouTube Playlist Information";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmPlaylistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.BindingSource frmPlaylistBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxUrl;
        private MaterialSkin.Controls.MaterialRaisedButton btnGet;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private MaterialSkin.Controls.MaterialProgressBar prbStatus;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialListView listVideo;
    }
}
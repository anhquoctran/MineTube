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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaylist));
            this.prbStatus = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.txtboxUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.listVideos = new System.Windows.Forms.ListView();
            this.TitleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublisherCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrlCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDataMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.getPublisherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getVideoInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVideocomingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyVideoURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bwFetch = new System.ComponentModel.BackgroundWorker();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CommentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DislikeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qualityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDataMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // prbStatus
            // 
            this.prbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prbStatus.Depth = 0;
            this.prbStatus.Location = new System.Drawing.Point(286, 409);
            this.prbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(240, 5);
            this.prbStatus.Step = 1;
            this.prbStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(12, 379);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(786, 29);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "There are nothing to display";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.UseCompatibleTextRendering = true;
            // 
            // txtboxUrl
            // 
            this.txtboxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUrl.Depth = 0;
            this.txtboxUrl.Hint = "Enter YouTube playlist URL...";
            this.txtboxUrl.Location = new System.Drawing.Point(12, 138);
            this.txtboxUrl.MaxLength = 32767;
            this.txtboxUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxUrl.Name = "txtboxUrl";
            this.txtboxUrl.PasswordChar = '\0';
            this.txtboxUrl.SelectedText = "";
            this.txtboxUrl.SelectionLength = 0;
            this.txtboxUrl.SelectionStart = 0;
            this.txtboxUrl.Size = new System.Drawing.Size(665, 23);
            this.txtboxUrl.TabIndex = 8;
            this.txtboxUrl.TabStop = false;
            this.txtboxUrl.UseSystemPasswordChar = false;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.Depth = 0;
            this.btnGet.Location = new System.Drawing.Point(683, 120);
            this.btnGet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGet.Name = "btnGet";
            this.btnGet.Primary = true;
            this.btnGet.Size = new System.Drawing.Size(114, 41);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Grab now!";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(13, 70);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(73, 36);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Go Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listVideos
            // 
            this.listVideos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVideos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleCol,
            this.DurationCol,
            this.PublisherCol,
            this.ViewCol,
            this.CommentCol,
            this.qualityCol,
            this.LikeCol,
            this.DislikeCol,
            this.UrlCol,
            this.publisherIdCol});
            this.listVideos.ContextMenuStrip = this.listDataMenu;
            this.listVideos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listVideos.FullRowSelect = true;
            this.listVideos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVideos.HideSelection = false;
            this.listVideos.Location = new System.Drawing.Point(13, 196);
            this.listVideos.Name = "listVideos";
            this.listVideos.ShowGroups = false;
            this.listVideos.ShowItemToolTips = true;
            this.listVideos.Size = new System.Drawing.Size(785, 411);
            this.listVideos.TabIndex = 14;
            this.listVideos.UseCompatibleStateImageBehavior = false;
            this.listVideos.View = System.Windows.Forms.View.Details;
            // 
            // TitleCol
            // 
            this.TitleCol.Text = "Title";
            this.TitleCol.Width = 123;
            // 
            // DurationCol
            // 
            this.DurationCol.Text = "Duration";
            this.DurationCol.Width = 148;
            // 
            // PublisherCol
            // 
            this.PublisherCol.Text = "Publisher";
            this.PublisherCol.Width = 182;
            // 
            // UrlCol
            // 
            this.UrlCol.Text = "URL";
            this.UrlCol.Width = 188;
            // 
            // publisherIdCol
            // 
            this.publisherIdCol.Text = "Publisher ID";
            this.publisherIdCol.Width = 107;
            // 
            // listDataMenu
            // 
            this.listDataMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listDataMenu.Depth = 0;
            this.listDataMenu.DropShadowEnabled = false;
            this.listDataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getPublisherInformationToolStripMenuItem,
            this.getVideoInformationToolStripMenuItem,
            this.viewVideocomingSoonToolStripMenuItem,
            this.copyVideoURLToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem,
            this.clearAllItemsToolStripMenuItem});
            this.listDataMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.listDataMenu.Name = "listDataMenu";
            this.listDataMenu.Size = new System.Drawing.Size(213, 142);
            this.listDataMenu.Opening += new System.ComponentModel.CancelEventHandler(this.listDataMenu_Opening);
            // 
            // getPublisherInformationToolStripMenuItem
            // 
            this.getPublisherInformationToolStripMenuItem.Enabled = false;
            this.getPublisherInformationToolStripMenuItem.Name = "getPublisherInformationToolStripMenuItem";
            this.getPublisherInformationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.getPublisherInformationToolStripMenuItem.Text = "Get Publisher Information";
            this.getPublisherInformationToolStripMenuItem.Click += new System.EventHandler(this.getPublisherInformationToolStripMenuItem_Click);
            // 
            // getVideoInformationToolStripMenuItem
            // 
            this.getVideoInformationToolStripMenuItem.Enabled = false;
            this.getVideoInformationToolStripMenuItem.Name = "getVideoInformationToolStripMenuItem";
            this.getVideoInformationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.getVideoInformationToolStripMenuItem.Text = "Get Video Information";
            this.getVideoInformationToolStripMenuItem.Click += new System.EventHandler(this.getVideoInformationToolStripMenuItem_Click);
            // 
            // viewVideocomingSoonToolStripMenuItem
            // 
            this.viewVideocomingSoonToolStripMenuItem.Enabled = false;
            this.viewVideocomingSoonToolStripMenuItem.Name = "viewVideocomingSoonToolStripMenuItem";
            this.viewVideocomingSoonToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.viewVideocomingSoonToolStripMenuItem.Text = "View video (coming soon)";
            // 
            // copyVideoURLToolStripMenuItem
            // 
            this.copyVideoURLToolStripMenuItem.Enabled = false;
            this.copyVideoURLToolStripMenuItem.Name = "copyVideoURLToolStripMenuItem";
            this.copyVideoURLToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copyVideoURLToolStripMenuItem.Text = "Copy video URL";
            this.copyVideoURLToolStripMenuItem.Click += new System.EventHandler(this.copyVideoURLToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearToolStripMenuItem.ShowShortcutKeys = false;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.clearToolStripMenuItem.Text = "Clear this item";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // clearAllItemsToolStripMenuItem
            // 
            this.clearAllItemsToolStripMenuItem.Enabled = false;
            this.clearAllItemsToolStripMenuItem.Name = "clearAllItemsToolStripMenuItem";
            this.clearAllItemsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.clearAllItemsToolStripMenuItem.Text = "Clear all items";
            this.clearAllItemsToolStripMenuItem.Click += new System.EventHandler(this.clearAllItemsToolStripMenuItem_Click);
            // 
            // bwFetch
            // 
            this.bwFetch.WorkerReportsProgress = true;
            this.bwFetch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwFetch_DoWork);
            this.bwFetch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwFetch_ProgressChanged);
            this.bwFetch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwFetch_RunWorkerCompleted);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // CommentCol
            // 
            this.CommentCol.Text = "Comments";
            // 
            // LikeCol
            // 
            this.LikeCol.Text = "Like";
            // 
            // DislikeCol
            // 
            this.DislikeCol.Text = "Dislike";
            // 
            // qualityCol
            // 
            this.qualityCol.Text = "Quality";
            // 
            // ViewCol
            // 
            this.ViewCol.Text = "View";
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 619);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.prbStatus);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtboxUrl);
            this.Controls.Add(this.listVideos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(810, 619);
            this.Name = "frmPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YouTube Playlist Information";
            this.listDataMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxUrl;
        private MaterialSkin.Controls.MaterialRaisedButton btnGet;
        private MaterialSkin.Controls.MaterialProgressBar prbStatus;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.ListView listVideos;
        private System.Windows.Forms.ColumnHeader TitleCol;
        private System.Windows.Forms.ColumnHeader DurationCol;
        private System.Windows.Forms.ColumnHeader PublisherCol;
        private System.Windows.Forms.ColumnHeader UrlCol;
        private System.ComponentModel.BackgroundWorker bwFetch;
        private MaterialSkin.Controls.MaterialContextMenuStrip listDataMenu;
        private System.Windows.Forms.ToolStripMenuItem getPublisherInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getVideoInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyVideoURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader publisherIdCol;
        private System.Windows.Forms.ToolStripMenuItem clearAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVideocomingSoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader CommentCol;
        private System.Windows.Forms.ColumnHeader LikeCol;
        private System.Windows.Forms.ColumnHeader DislikeCol;
        private System.Windows.Forms.ColumnHeader qualityCol;
        private System.Windows.Forms.ColumnHeader ViewCol;
    }
}
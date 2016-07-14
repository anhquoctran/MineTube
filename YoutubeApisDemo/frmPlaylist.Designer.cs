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
            this.txtboxUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.listVideos = new System.Windows.Forms.ListView();
            this.IdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublisherCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PublishDateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qualityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DislikeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrlCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuContextVideo = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.viewVideocomingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyVideoURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPublisherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getVideoInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadWithInternetDownloadManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrev = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnGrab = new System.Windows.Forms.Button();
            this.lblTitlePlaylist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChannelOwner = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.menuThumbs = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.copyThumbnailURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveThumbnailImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImg = new System.Windows.Forms.SaveFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picThumbs = new System.Windows.Forms.PictureBox();
            this.menuContextVideo.SuspendLayout();
            this.menuThumbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUrl
            // 
            this.txtboxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUrl.Depth = 0;
            this.txtboxUrl.Hint = "Enter a playlist ID";
            this.txtboxUrl.Location = new System.Drawing.Point(12, 115);
            this.txtboxUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxUrl.Name = "txtboxUrl";
            this.txtboxUrl.PasswordChar = '\0';
            this.txtboxUrl.SelectedText = "";
            this.txtboxUrl.SelectionLength = 0;
            this.txtboxUrl.SelectionStart = 0;
            this.txtboxUrl.Size = new System.Drawing.Size(1482, 23);
            this.txtboxUrl.TabIndex = 8;
            this.txtboxUrl.TabStop = false;
            this.txtboxUrl.UseSystemPasswordChar = false;
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
            this.IdCol,
            this.TitleCol,
            this.DurationCol,
            this.PublisherCol,
            this.PublishDateCol,
            this.ViewCol,
            this.CommentCol,
            this.qualityCol,
            this.LikeCol,
            this.DislikeCol,
            this.UrlCol,
            this.publisherIdCol});
            this.listVideos.ContextMenuStrip = this.menuContextVideo;
            this.listVideos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listVideos.FullRowSelect = true;
            this.listVideos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVideos.HideSelection = false;
            this.listVideos.Location = new System.Drawing.Point(13, 306);
            this.listVideos.MultiSelect = false;
            this.listVideos.Name = "listVideos";
            this.listVideos.ShowGroups = false;
            this.listVideos.ShowItemToolTips = true;
            this.listVideos.Size = new System.Drawing.Size(1591, 400);
            this.listVideos.TabIndex = 14;
            this.listVideos.UseCompatibleStateImageBehavior = false;
            this.listVideos.View = System.Windows.Forms.View.Details;
            this.listVideos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listVideos_MouseDoubleClick);
            // 
            // IdCol
            // 
            this.IdCol.Text = "#";
            this.IdCol.Width = 35;
            // 
            // TitleCol
            // 
            this.TitleCol.Text = "Title";
            this.TitleCol.Width = 420;
            // 
            // DurationCol
            // 
            this.DurationCol.Text = "Duration";
            this.DurationCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DurationCol.Width = 90;
            // 
            // PublisherCol
            // 
            this.PublisherCol.Text = "Publisher";
            this.PublisherCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PublisherCol.Width = 120;
            // 
            // PublishDateCol
            // 
            this.PublishDateCol.Text = "Published Date";
            this.PublishDateCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PublishDateCol.Width = 105;
            // 
            // ViewCol
            // 
            this.ViewCol.Text = "Views";
            this.ViewCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewCol.Width = 100;
            // 
            // CommentCol
            // 
            this.CommentCol.Text = "Comments";
            this.CommentCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CommentCol.Width = 100;
            // 
            // qualityCol
            // 
            this.qualityCol.Text = "Quality";
            this.qualityCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LikeCol
            // 
            this.LikeCol.Text = "Like";
            this.LikeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LikeCol.Width = 100;
            // 
            // DislikeCol
            // 
            this.DislikeCol.Text = "Dislike";
            this.DislikeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DislikeCol.Width = 100;
            // 
            // UrlCol
            // 
            this.UrlCol.Text = "URL";
            this.UrlCol.Width = 330;
            // 
            // publisherIdCol
            // 
            this.publisherIdCol.Text = "Publisher ID";
            this.publisherIdCol.Width = 107;
            // 
            // menuContextVideo
            // 
            this.menuContextVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuContextVideo.Depth = 0;
            this.menuContextVideo.DropShadowEnabled = false;
            this.menuContextVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVideocomingSoonToolStripMenuItem,
            this.copyVideoURLToolStripMenuItem,
            this.getPublisherInformationToolStripMenuItem,
            this.getVideoInformationToolStripMenuItem,
            this.toolStripSeparator2,
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem,
            this.downloadWithInternetDownloadManagerToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem,
            this.clearAllItemsToolStripMenuItem});
            this.menuContextVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuContextVideo.Name = "listDataMenu";
            this.menuContextVideo.Size = new System.Drawing.Size(204, 192);
            this.menuContextVideo.Opening += new System.ComponentModel.CancelEventHandler(this.listDataMenu_Opening);
            // 
            // viewVideocomingSoonToolStripMenuItem
            // 
            this.viewVideocomingSoonToolStripMenuItem.Enabled = false;
            this.viewVideocomingSoonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewVideocomingSoonToolStripMenuItem.Image")));
            this.viewVideocomingSoonToolStripMenuItem.Name = "viewVideocomingSoonToolStripMenuItem";
            this.viewVideocomingSoonToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewVideocomingSoonToolStripMenuItem.Text = "Play";
            // 
            // copyVideoURLToolStripMenuItem
            // 
            this.copyVideoURLToolStripMenuItem.Enabled = false;
            this.copyVideoURLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyVideoURLToolStripMenuItem.Image")));
            this.copyVideoURLToolStripMenuItem.Name = "copyVideoURLToolStripMenuItem";
            this.copyVideoURLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyVideoURLToolStripMenuItem.ShowShortcutKeys = false;
            this.copyVideoURLToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.copyVideoURLToolStripMenuItem.Text = "Copy video URL";
            this.copyVideoURLToolStripMenuItem.Click += new System.EventHandler(this.copyVideoURLToolStripMenuItem_Click);
            // 
            // getPublisherInformationToolStripMenuItem
            // 
            this.getPublisherInformationToolStripMenuItem.Enabled = false;
            this.getPublisherInformationToolStripMenuItem.Name = "getPublisherInformationToolStripMenuItem";
            this.getPublisherInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.getPublisherInformationToolStripMenuItem.ShowShortcutKeys = false;
            this.getPublisherInformationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.getPublisherInformationToolStripMenuItem.Text = "Get Publisher Information";
            this.getPublisherInformationToolStripMenuItem.Click += new System.EventHandler(this.getPublisherInformationToolStripMenuItem_Click);
            // 
            // getVideoInformationToolStripMenuItem
            // 
            this.getVideoInformationToolStripMenuItem.Enabled = false;
            this.getVideoInformationToolStripMenuItem.Name = "getVideoInformationToolStripMenuItem";
            this.getVideoInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.getVideoInformationToolStripMenuItem.ShowShortcutKeys = false;
            this.getVideoInformationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.getVideoInformationToolStripMenuItem.Text = "Get Video Information";
            this.getVideoInformationToolStripMenuItem.Click += new System.EventHandler(this.getVideoInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // downloadWithOurDownloadToolcomingSoonToolStripMenuItem
            // 
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Image")));
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Name = "downloadWithOurDownloadToolcomingSoonToolStripMenuItem";
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Text = "Download";
            this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem.Click += new System.EventHandler(this.downloadWithOurDownloadToolcomingSoonToolStripMenuItem_Click);
            // 
            // downloadWithInternetDownloadManagerToolStripMenuItem
            // 
            this.downloadWithInternetDownloadManagerToolStripMenuItem.Enabled = false;
            this.downloadWithInternetDownloadManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadWithInternetDownloadManagerToolStripMenuItem.Image")));
            this.downloadWithInternetDownloadManagerToolStripMenuItem.Name = "downloadWithInternetDownloadManagerToolStripMenuItem";
            this.downloadWithInternetDownloadManagerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.downloadWithInternetDownloadManagerToolStripMenuItem.Text = "Download with IDM";
            this.downloadWithInternetDownloadManagerToolStripMenuItem.Click += new System.EventHandler(this.downloadWithInternetDownloadManagerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.clearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.clearToolStripMenuItem.ShowShortcutKeys = false;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.clearToolStripMenuItem.Text = "Clear this video";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // clearAllItemsToolStripMenuItem
            // 
            this.clearAllItemsToolStripMenuItem.Enabled = false;
            this.clearAllItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearAllItemsToolStripMenuItem.Image")));
            this.clearAllItemsToolStripMenuItem.Name = "clearAllItemsToolStripMenuItem";
            this.clearAllItemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.clearAllItemsToolStripMenuItem.ShowShortcutKeys = false;
            this.clearAllItemsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.clearAllItemsToolStripMenuItem.Text = "Clear all videos";
            this.clearAllItemsToolStripMenuItem.Click += new System.EventHandler(this.clearAllItemsToolStripMenuItem_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(1557, 715);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = false;
            this.btnNext.Size = new System.Drawing.Size(46, 36);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.AutoSize = true;
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.Depth = 0;
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(1503, 715);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Primary = false;
            this.btnPrev.Size = new System.Drawing.Size(46, 36);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCounter.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCounter.Location = new System.Drawing.Point(24, 724);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(159, 17);
            this.lblCounter.TabIndex = 18;
            this.lblCounter.Text = "0 videos in 0 videos total";
            // 
            // btnGrab
            // 
            this.btnGrab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnGrab.FlatAppearance.BorderSize = 0;
            this.btnGrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrab.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGrab.ForeColor = System.Drawing.Color.White;
            this.btnGrab.Location = new System.Drawing.Point(1500, 102);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(104, 36);
            this.btnGrab.TabIndex = 20;
            this.btnGrab.Text = "GRAB";
            this.btnGrab.UseVisualStyleBackColor = false;
            this.btnGrab.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblTitlePlaylist
            // 
            this.lblTitlePlaylist.AutoSize = true;
            this.lblTitlePlaylist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitlePlaylist.Location = new System.Drawing.Point(238, 144);
            this.lblTitlePlaylist.Name = "lblTitlePlaylist";
            this.lblTitlePlaylist.Size = new System.Drawing.Size(203, 21);
            this.lblTitlePlaylist.TabIndex = 22;
            this.lblTitlePlaylist.Text = "We haven\'t received data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(239, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Owner:";
            // 
            // lblChannelOwner
            // 
            this.lblChannelOwner.AutoSize = true;
            this.lblChannelOwner.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblChannelOwner.LinkColor = System.Drawing.Color.Red;
            this.lblChannelOwner.Location = new System.Drawing.Point(290, 165);
            this.lblChannelOwner.Name = "lblChannelOwner";
            this.lblChannelOwner.Size = new System.Drawing.Size(72, 15);
            this.lblChannelOwner.TabIndex = 24;
            this.lblChannelOwner.TabStop = true;
            this.lblChannelOwner.Text = "ownerName";
            this.lblChannelOwner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChannelOwner_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(239, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Published date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(333, 180);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 15);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(239, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Description:";
            // 
            // richDescription
            // 
            this.richDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richDescription.BackColor = System.Drawing.Color.White;
            this.richDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richDescription.ForeColor = System.Drawing.Color.White;
            this.richDescription.Location = new System.Drawing.Point(242, 213);
            this.richDescription.Name = "richDescription";
            this.richDescription.ReadOnly = true;
            this.richDescription.Size = new System.Drawing.Size(1362, 75);
            this.richDescription.TabIndex = 28;
            this.richDescription.Text = "";
            // 
            // menuThumbs
            // 
            this.menuThumbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuThumbs.Depth = 0;
            this.menuThumbs.DropShadowEnabled = false;
            this.menuThumbs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyThumbnailURLToolStripMenuItem,
            this.saveThumbnailImageToolStripMenuItem});
            this.menuThumbs.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuThumbs.Name = "menuThumbs";
            this.menuThumbs.Size = new System.Drawing.Size(185, 48);
            this.menuThumbs.Opening += new System.ComponentModel.CancelEventHandler(this.menuThumbs_Opening);
            // 
            // copyThumbnailURLToolStripMenuItem
            // 
            this.copyThumbnailURLToolStripMenuItem.Name = "copyThumbnailURLToolStripMenuItem";
            this.copyThumbnailURLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyThumbnailURLToolStripMenuItem.Text = "Copy thumbnail URL";
            this.copyThumbnailURLToolStripMenuItem.Click += new System.EventHandler(this.copyThumbnailURLToolStripMenuItem_Click);
            // 
            // saveThumbnailImageToolStripMenuItem
            // 
            this.saveThumbnailImageToolStripMenuItem.Name = "saveThumbnailImageToolStripMenuItem";
            this.saveThumbnailImageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveThumbnailImageToolStripMenuItem.Text = "Save image as...";
            this.saveThumbnailImageToolStripMenuItem.Click += new System.EventHandler(this.saveThumbnailImageToolStripMenuItem_Click);
            // 
            // saveImg
            // 
            this.saveImg.AddExtension = false;
            this.saveImg.Title = "Save as";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Location = new System.Drawing.Point(10, 519);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1594, 41);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "There are nothing to display";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picThumbs
            // 
            this.picThumbs.ContextMenuStrip = this.menuThumbs;
            this.picThumbs.Image = global::YoutubeApisDemo.Properties.Resources.thumbnail_video;
            this.picThumbs.Location = new System.Drawing.Point(13, 144);
            this.picThumbs.Name = "picThumbs";
            this.picThumbs.Size = new System.Drawing.Size(219, 144);
            this.picThumbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumbs.TabIndex = 21;
            this.picThumbs.TabStop = false;
            // 
            // frmPlaylist
            // 
            this.AcceptButton = this.btnGrab;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1616, 766);
            this.ControlBox = false;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.richDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChannelOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitlePlaylist);
            this.Controls.Add(this.picThumbs);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxUrl);
            this.Controls.Add(this.listVideos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1616, 766);
            this.Name = "frmPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Playlist Information";
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
            this.menuContextVideo.ResumeLayout(false);
            this.menuThumbs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxUrl;
        //private MaterialSkin.Controls.MaterialProgressBar prbStatus;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.ListView listVideos;
        private System.Windows.Forms.ColumnHeader TitleCol;
        private System.Windows.Forms.ColumnHeader DurationCol;
        private System.Windows.Forms.ColumnHeader PublisherCol;
        private System.Windows.Forms.ColumnHeader UrlCol;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuContextVideo;
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
        private MaterialSkin.Controls.MaterialFlatButton btnNext;
        private MaterialSkin.Controls.MaterialFlatButton btnPrev;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ColumnHeader IdCol;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.PictureBox picThumbs;
        private System.Windows.Forms.Label lblTitlePlaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblChannelOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richDescription;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuThumbs;
        private System.Windows.Forms.ToolStripMenuItem copyThumbnailURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveThumbnailImageToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveImg;
        private System.Windows.Forms.ColumnHeader PublishDateCol;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem downloadWithOurDownloadToolcomingSoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadWithInternetDownloadManagerToolStripMenuItem;
    }
}
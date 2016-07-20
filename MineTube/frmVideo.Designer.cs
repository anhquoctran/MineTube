namespace MineTube
{
    partial class frmVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideo));
            this.pnlVideoInfo = new System.Windows.Forms.Panel();
            this.lblLoadStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchtxtTags = new System.Windows.Forms.RichTextBox();
            this.lblPub = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.RichTextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblLikeDislike = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.picVideoThumb = new System.Windows.Forms.PictureBox();
            this.menuThumbs = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.copyImageURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtboxSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPaste = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picAvatarUser = new MineTube.CirclePictureBox();
            this.pnlVideoInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoThumb)).BeginInit();
            this.menuThumbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVideoInfo
            // 
            this.pnlVideoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVideoInfo.BackColor = System.Drawing.Color.White;
            this.pnlVideoInfo.Controls.Add(this.lblLoadStatus);
            this.pnlVideoInfo.Controls.Add(this.lblCategory);
            this.pnlVideoInfo.Controls.Add(this.btnReset);
            this.pnlVideoInfo.Controls.Add(this.lblDefinition);
            this.pnlVideoInfo.Controls.Add(this.lblDimension);
            this.pnlVideoInfo.Controls.Add(this.groupBox2);
            this.pnlVideoInfo.Controls.Add(this.lblPub);
            this.pnlVideoInfo.Controls.Add(this.label1);
            this.pnlVideoInfo.Controls.Add(this.lblDuration);
            this.pnlVideoInfo.Controls.Add(this.pnlDescription);
            this.pnlVideoInfo.Controls.Add(this.lblPublisher);
            this.pnlVideoInfo.Controls.Add(this.lblComment);
            this.pnlVideoInfo.Controls.Add(this.lblLikeDislike);
            this.pnlVideoInfo.Controls.Add(this.lblView);
            this.pnlVideoInfo.Controls.Add(this.lblDate);
            this.pnlVideoInfo.Controls.Add(this.lblVideoTitle);
            this.pnlVideoInfo.Controls.Add(this.picVideoThumb);
            this.pnlVideoInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlVideoInfo.Location = new System.Drawing.Point(12, 115);
            this.pnlVideoInfo.Name = "pnlVideoInfo";
            this.pnlVideoInfo.Size = new System.Drawing.Size(677, 576);
            this.pnlVideoInfo.TabIndex = 4;
            // 
            // lblLoadStatus
            // 
            this.lblLoadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadStatus.AutoSize = true;
            this.lblLoadStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoadStatus.Location = new System.Drawing.Point(551, 193);
            this.lblLoadStatus.Name = "lblLoadStatus";
            this.lblLoadStatus.Size = new System.Drawing.Size(88, 15);
            this.lblLoadStatus.TabIndex = 17;
            this.lblLoadStatus.Text = "Working on it...";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategory.Location = new System.Drawing.Point(226, 127);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 17);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(645, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(32, 32);
            this.btnReset.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnReset, "Đặt lại");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDefinition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDefinition.ForeColor = System.Drawing.Color.Transparent;
            this.lblDefinition.Location = new System.Drawing.Point(161, 140);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(31, 20);
            this.lblDefinition.TabIndex = 14;
            this.lblDefinition.Text = "HD";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.BackColor = System.Drawing.Color.DarkGray;
            this.lblDimension.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDimension.ForeColor = System.Drawing.Color.Transparent;
            this.lblDimension.Location = new System.Drawing.Point(190, 140);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(29, 20);
            this.lblDimension.TabIndex = 13;
            this.lblDimension.Text = "3D";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rchtxtTags);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 99);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags";
            // 
            // rchtxtTags
            // 
            this.rchtxtTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchtxtTags.BackColor = System.Drawing.Color.White;
            this.rchtxtTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtxtTags.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtTags.Location = new System.Drawing.Point(3, 21);
            this.rchtxtTags.Name = "rchtxtTags";
            this.rchtxtTags.ReadOnly = true;
            this.rchtxtTags.Size = new System.Drawing.Size(671, 75);
            this.rchtxtTags.TabIndex = 0;
            this.rchtxtTags.Text = "";
            // 
            // lblPub
            // 
            this.lblPub.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lblPub.AutoEllipsis = true;
            this.lblPub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblPub.LinkColor = System.Drawing.Color.Red;
            this.lblPub.Location = new System.Drawing.Point(290, 37);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(97, 17);
            this.lblPub.TabIndex = 11;
            this.lblPub.TabStop = true;
            this.lblPub.Text = "publisherName";
            this.lblPub.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.lblPub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPub_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(-3, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(-1, 140);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(65, 20);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "00:00:00";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDescription
            // 
            this.pnlDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescription.AutoScroll = true;
            this.pnlDescription.BackColor = System.Drawing.Color.White;
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Location = new System.Drawing.Point(0, 218);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(678, 242);
            this.pnlDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescription.BulletIndent = 1;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(0, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.ReadOnly = true;
            this.lblDescription.Size = new System.Drawing.Size(675, 236);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.TabStop = false;
            this.lblDescription.Text = "";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPublisher.Location = new System.Drawing.Point(226, 37);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(64, 17);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblComment.Location = new System.Drawing.Point(226, 110);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(64, 17);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Comment";
            // 
            // lblLikeDislike
            // 
            this.lblLikeDislike.AutoSize = true;
            this.lblLikeDislike.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLikeDislike.Location = new System.Drawing.Point(226, 93);
            this.lblLikeDislike.Name = "lblLikeDislike";
            this.lblLikeDislike.Size = new System.Drawing.Size(80, 17);
            this.lblLikeDislike.TabIndex = 5;
            this.lblLikeDislike.Text = "Like - Dislike";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblView.Location = new System.Drawing.Point(226, 74);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(83, 17);
            this.lblView.TabIndex = 4;
            this.lblView.Text = "View counter";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDate.Location = new System.Drawing.Point(226, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date published";
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVideoTitle.AutoEllipsis = true;
            this.lblVideoTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVideoTitle.Location = new System.Drawing.Point(225, 16);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(450, 21);
            this.lblVideoTitle.TabIndex = 1;
            this.lblVideoTitle.Text = "Title";
            // 
            // picVideoThumb
            // 
            this.picVideoThumb.ContextMenuStrip = this.menuThumbs;
            this.picVideoThumb.Location = new System.Drawing.Point(0, 16);
            this.picVideoThumb.Name = "picVideoThumb";
            this.picVideoThumb.Size = new System.Drawing.Size(219, 144);
            this.picVideoThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideoThumb.TabIndex = 0;
            this.picVideoThumb.TabStop = false;
            // 
            // menuThumbs
            // 
            this.menuThumbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuThumbs.Depth = 0;
            this.menuThumbs.DropShadowEnabled = false;
            this.menuThumbs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageURLToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.menuThumbs.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuThumbs.Name = "menuThumbs";
            this.menuThumbs.Size = new System.Drawing.Size(163, 48);
            this.menuThumbs.Opening += new System.ComponentModel.CancelEventHandler(this.menuThumbs_Opening);
            // 
            // copyImageURLToolStripMenuItem
            // 
            this.copyImageURLToolStripMenuItem.Name = "copyImageURLToolStripMenuItem";
            this.copyImageURLToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copyImageURLToolStripMenuItem.Text = "Copy image URL";
            this.copyImageURLToolStripMenuItem.Click += new System.EventHandler(this.copyImageURLToolStripMenuItem_Click);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save image as...";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearch.Depth = 0;
            this.txtboxSearch.Hint = "Enter or paste YouTube video URL...";
            this.txtboxSearch.Location = new System.Drawing.Point(15, 86);
            this.txtboxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.PasswordChar = '\0';
            this.txtboxSearch.SelectedText = "";
            this.txtboxSearch.SelectionLength = 0;
            this.txtboxSearch.SelectionStart = 0;
            this.txtboxSearch.Size = new System.Drawing.Size(519, 23);
            this.txtboxSearch.TabIndex = 19;
            this.txtboxSearch.TabStop = false;
            this.txtboxSearch.UseSystemPasswordChar = false;
            this.txtboxSearch.Click += new System.EventHandler(this.txtboxSearch_Click);
            this.txtboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxSearch_KeyDown);
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.Depth = 0;
            this.btnPaste.Location = new System.Drawing.Point(540, 72);
            this.btnPaste.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Primary = true;
            this.btnPaste.Size = new System.Drawing.Size(66, 37);
            this.btnPaste.TabIndex = 18;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Depth = 0;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(612, 72);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(78, 37);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Go »";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(593, 697);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(97, 41);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Go Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(9, 725);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(38, 13);
            this.lblVersion.TabIndex = 21;
            this.lblVersion.Text = "label2";
            // 
            // picAvatarUser
            // 
            this.picAvatarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAvatarUser.Image = global::MineTube.Properties.Resources.null_avatar;
            this.picAvatarUser.Location = new System.Drawing.Point(658, 29);
            this.picAvatarUser.Name = "picAvatarUser";
            this.picAvatarUser.Size = new System.Drawing.Size(32, 32);
            this.picAvatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarUser.TabIndex = 22;
            this.picAvatarUser.TabStop = false;
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 747);
            this.ControlBox = false;
            this.Controls.Add(this.picAvatarUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlVideoInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.btnPaste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 747);
            this.MinimumSize = new System.Drawing.Size(701, 747);
            this.Name = "frmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Video Information";
            this.pnlVideoInfo.ResumeLayout(false);
            this.pnlVideoInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVideoThumb)).EndInit();
            this.menuThumbs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlVideoInfo;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.PictureBox picVideoThumb;
        private System.Windows.Forms.Label lblLikeDislike;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox lblDescription;
        private System.Windows.Forms.LinkLabel lblPub;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchtxtTags;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLoadStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnPaste;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private System.Windows.Forms.Label lblVersion;
        public MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private MaterialSkin.Controls.MaterialContextMenuStrip menuThumbs;
        private System.Windows.Forms.ToolStripMenuItem copyImageURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private CirclePictureBox picAvatarUser;
    }
}


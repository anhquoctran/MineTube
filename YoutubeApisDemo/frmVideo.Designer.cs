namespace YoutubeApisDemo
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFrm = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkMin = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.txtboxSearch = new YoutubeApisDemo.PlaceholderTextBox();
            this.lblLoadStatus = new System.Windows.Forms.Label();
            this.pnlVideoInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoThumb)).BeginInit();
            this.pnlFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
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
            this.pnlVideoInfo.Location = new System.Drawing.Point(13, 86);
            this.pnlVideoInfo.Name = "pnlVideoInfo";
            this.pnlVideoInfo.Size = new System.Drawing.Size(677, 571);
            this.pnlVideoInfo.TabIndex = 4;
            this.pnlVideoInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlVideoInfo_MouseDown);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategory.Location = new System.Drawing.Point(226, 127);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 17);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Thể loại:";
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
            this.groupBox2.Location = new System.Drawing.Point(0, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 99);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags";
            // 
            // rchtxtTags
            // 
            this.rchtxtTags.BackColor = System.Drawing.Color.White;
            this.rchtxtTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtxtTags.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.lblPub.AutoSize = true;
            this.lblPub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblPub.Location = new System.Drawing.Point(307, 36);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(62, 17);
            this.lblPub.TabIndex = 11;
            this.lblPub.TabStop = true;
            this.lblPub.Text = "publisher";
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
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mô tả:";
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
            this.pnlDescription.Size = new System.Drawing.Size(678, 237);
            this.pnlDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(-2, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.ReadOnly = true;
            this.lblDescription.Size = new System.Drawing.Size(677, 245);
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
            this.lblPublisher.Size = new System.Drawing.Size(82, 17);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Người đăng:";
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
            this.picVideoThumb.Location = new System.Drawing.Point(0, 16);
            this.picVideoThumb.Name = "picVideoThumb";
            this.picVideoThumb.Size = new System.Drawing.Size(219, 144);
            this.picVideoThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideoThumb.TabIndex = 0;
            this.picVideoThumb.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(31)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(627, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 27);
            this.btnSearch.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSearch, "Thực thi");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.Location = new System.Drawing.Point(13, 53);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(54, 27);
            this.btnPaste.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnPaste, "Dán");
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(33, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(517, 19);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // pnlFrm
            // 
            this.pnlFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrm.Controls.Add(this.btnClose);
            this.pnlFrm.Controls.Add(this.chkMin);
            this.pnlFrm.Controls.Add(this.chkMax);
            this.pnlFrm.Controls.Add(this.picIcon);
            this.pnlFrm.Controls.Add(this.txtboxSearch);
            this.pnlFrm.Controls.Add(this.lblTitle);
            this.pnlFrm.Controls.Add(this.btnSearch);
            this.pnlFrm.Controls.Add(this.btnPaste);
            this.pnlFrm.Controls.Add(this.pnlVideoInfo);
            this.pnlFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlFrm.Name = "pnlFrm";
            this.pnlFrm.Size = new System.Drawing.Size(706, 673);
            this.pnlFrm.TabIndex = 8;
            this.pnlFrm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFrm_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(657, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkMin
            // 
            this.chkMin.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMin.BackColor = System.Drawing.Color.Transparent;
            this.chkMin.FlatAppearance.BorderSize = 0;
            this.chkMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMin.Image = ((System.Drawing.Image)(resources.GetObject("chkMin.Image")));
            this.chkMin.Location = new System.Drawing.Point(556, -1);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(47, 27);
            this.chkMin.TabIndex = 10;
            this.chkMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMin.UseVisualStyleBackColor = false;
            this.chkMin.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
            // 
            // chkMax
            // 
            this.chkMax.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMax.BackColor = System.Drawing.Color.Transparent;
            this.chkMax.FlatAppearance.BorderSize = 0;
            this.chkMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMax.Image = ((System.Drawing.Image)(resources.GetObject("chkMax.Image")));
            this.chkMax.Location = new System.Drawing.Point(609, 0);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(47, 27);
            this.chkMax.TabIndex = 9;
            this.chkMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMax.UseVisualStyleBackColor = false;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(11, 11);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(16, 16);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtboxSearch.ForeColor = System.Drawing.Color.Red;
            this.txtboxSearch.Location = new System.Drawing.Point(63, 53);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.PlaceholderText = "YouTube URL...";
            this.txtboxSearch.Size = new System.Drawing.Size(568, 27);
            this.txtboxSearch.TabIndex = 1;
            this.txtboxSearch.Click += new System.EventHandler(this.txtboxSearch_Click);
            this.txtboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxSearch_KeyDown);
            // 
            // lblLoadStatus
            // 
            this.lblLoadStatus.AutoSize = true;
            this.lblLoadStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoadStatus.Location = new System.Drawing.Point(567, 193);
            this.lblLoadStatus.Name = "lblLoadStatus";
            this.lblLoadStatus.Size = new System.Drawing.Size(60, 15);
            this.lblLoadStatus.TabIndex = 17;
            this.lblLoadStatus.Text = "Đang tải...";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 673);
            this.Controls.Add(this.pnlFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(687, 620);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube API v3 Demo";
            this.pnlVideoInfo.ResumeLayout(false);
            this.pnlVideoInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVideoThumb)).EndInit();
            this.pnlFrm.ResumeLayout(false);
            this.pnlFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PlaceholderTextBox txtboxSearch;
        private System.Windows.Forms.Button btnSearch;
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
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel pnlFrm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.Label lblLoadStatus;
    }
}


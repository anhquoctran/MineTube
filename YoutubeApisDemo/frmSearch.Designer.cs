namespace YoutubeApisDemo
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnLong = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioBtnShort = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioBtnVideo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblStatusList = new MaterialSkin.Controls.MaterialLabel();
            this.prbStatus = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(709, 713);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(101, 43);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Go Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(12, 227);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.ShowGroups = false;
            this.materialListView1.Size = new System.Drawing.Size(798, 480);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.TileSize = new System.Drawing.Size(64, 64);
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Tile;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnLong);
            this.groupBox3.Controls.Add(this.radioBtnShort);
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(310, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durations";
            // 
            // radioBtnLong
            // 
            this.radioBtnLong.AutoSize = true;
            this.radioBtnLong.Depth = 0;
            this.radioBtnLong.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioBtnLong.Location = new System.Drawing.Point(175, 29);
            this.radioBtnLong.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnLong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtnLong.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtnLong.Name = "radioBtnLong";
            this.radioBtnLong.Ripple = true;
            this.radioBtnLong.Size = new System.Drawing.Size(152, 30);
            this.radioBtnLong.TabIndex = 2;
            this.radioBtnLong.TabStop = true;
            this.radioBtnLong.Text = "Long (> 20 minutes)";
            this.radioBtnLong.UseVisualStyleBackColor = true;
            // 
            // radioBtnShort
            // 
            this.radioBtnShort.AutoSize = true;
            this.radioBtnShort.Depth = 0;
            this.radioBtnShort.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioBtnShort.Location = new System.Drawing.Point(16, 29);
            this.radioBtnShort.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnShort.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtnShort.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtnShort.Name = "radioBtnShort";
            this.radioBtnShort.Ripple = true;
            this.radioBtnShort.Size = new System.Drawing.Size(146, 30);
            this.radioBtnShort.TabIndex = 1;
            this.radioBtnShort.TabStop = true;
            this.radioBtnShort.Text = "Short (< 4 minutes)";
            this.radioBtnShort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialRadioButton3);
            this.groupBox2.Controls.Add(this.materialRadioButton2);
            this.groupBox2.Controls.Add(this.radioBtnVideo);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton3.Location = new System.Drawing.Point(187, 29);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(86, 30);
            this.materialRadioButton3.TabIndex = 2;
            this.materialRadioButton3.Text = "Channels";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(90, 29);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(81, 30);
            this.materialRadioButton2.TabIndex = 1;
            this.materialRadioButton2.Text = "Playlists";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // radioBtnVideo
            // 
            this.radioBtnVideo.AutoSize = true;
            this.radioBtnVideo.Checked = true;
            this.radioBtnVideo.Depth = 0;
            this.radioBtnVideo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioBtnVideo.Location = new System.Drawing.Point(15, 29);
            this.radioBtnVideo.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnVideo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtnVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtnVideo.Name = "radioBtnVideo";
            this.radioBtnVideo.Ripple = true;
            this.radioBtnVideo.Size = new System.Drawing.Size(64, 30);
            this.radioBtnVideo.TabIndex = 0;
            this.radioBtnVideo.TabStop = true;
            this.radioBtnVideo.Text = "Video";
            this.radioBtnVideo.UseVisualStyleBackColor = true;
            this.radioBtnVideo.CheckedChanged += new System.EventHandler(this.radioBtnVideo_CheckedChanged);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.ForeColor = System.Drawing.Color.Gray;
            this.materialSingleLineTextField1.Hint = "Type to search...";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(12, 86);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(673, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(691, 71);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(121, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblStatusList
            // 
            this.lblStatusList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusList.Depth = 0;
            this.lblStatusList.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatusList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatusList.Location = new System.Drawing.Point(12, 413);
            this.lblStatusList.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatusList.Name = "lblStatusList";
            this.lblStatusList.Size = new System.Drawing.Size(798, 25);
            this.lblStatusList.TabIndex = 7;
            this.lblStatusList.Text = "There are nothing to display";
            this.lblStatusList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prbStatus
            // 
            this.prbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prbStatus.Depth = 0;
            this.prbStatus.Location = new System.Drawing.Point(284, 441);
            this.prbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(253, 5);
            this.prbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prbStatus.TabIndex = 8;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(9, 746);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(38, 13);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "label1";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 768);
            this.ControlBox = false;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.prbStatus);
            this.Controls.Add(this.lblStatusList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.materialListView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YouTube Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnLong;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnShort;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnVideo;
        private MaterialSkin.Controls.MaterialLabel lblStatusList;
        private MaterialSkin.Controls.MaterialProgressBar prbStatus;
        private System.Windows.Forms.Label lblVersion;
    }
}
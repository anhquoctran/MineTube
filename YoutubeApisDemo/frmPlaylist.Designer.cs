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
            this.listVideo = new MaterialSkin.Controls.MaterialListView();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // prbStatus
            // 
            this.prbStatus.Depth = 0;
            this.prbStatus.Location = new System.Drawing.Point(278, 411);
            this.prbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.prbStatus.Name = "prbStatus";
            this.prbStatus.Size = new System.Drawing.Size(243, 5);
            this.prbStatus.Step = 1;
            this.prbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prbStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(0, 379);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(797, 29);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "There are nothing to display";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxUrl
            // 
            this.txtboxUrl.Depth = 0;
            this.txtboxUrl.Hint = "Enter YouTube playlist URL...";
            this.txtboxUrl.Location = new System.Drawing.Point(13, 167);
            this.txtboxUrl.MaxLength = 32767;
            this.txtboxUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxUrl.Name = "txtboxUrl";
            this.txtboxUrl.PasswordChar = '\0';
            this.txtboxUrl.SelectedText = "";
            this.txtboxUrl.SelectionLength = 0;
            this.txtboxUrl.SelectionStart = 0;
            this.txtboxUrl.Size = new System.Drawing.Size(652, 23);
            this.txtboxUrl.TabIndex = 8;
            this.txtboxUrl.TabStop = false;
            this.txtboxUrl.UseSystemPasswordChar = false;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.Depth = 0;
            this.btnGet.Location = new System.Drawing.Point(671, 149);
            this.btnGet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGet.Name = "btnGet";
            this.btnGet.Primary = true;
            this.btnGet.Size = new System.Drawing.Size(114, 41);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Grab now!";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // listVideo
            // 
            this.listVideo.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVideo.AutoArrange = false;
            this.listVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listVideo.Depth = 0;
            this.listVideo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listVideo.Font = new System.Drawing.Font("Roboto", 11F);
            this.listVideo.FullRowSelect = true;
            this.listVideo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVideo.HoverSelection = true;
            this.listVideo.Location = new System.Drawing.Point(0, 196);
            this.listVideo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listVideo.MouseState = MaterialSkin.MouseState.OUT;
            this.listVideo.Name = "listVideo";
            this.listVideo.OwnerDraw = true;
            this.listVideo.ShowGroups = false;
            this.listVideo.Size = new System.Drawing.Size(797, 449);
            this.listVideo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listVideo.TabIndex = 12;
            this.listVideo.TileSize = new System.Drawing.Size(64, 64);
            this.listVideo.UseCompatibleStateImageBehavior = false;
            this.listVideo.View = System.Windows.Forms.View.Details;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 256;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Duration";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Published date";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "URL";
            this.columnHeader4.Width = 335;
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.prbStatus);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtboxUrl);
            this.Controls.Add(this.listVideo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YouTube Playlist Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxUrl;
        private MaterialSkin.Controls.MaterialRaisedButton btnGet;
        private MaterialSkin.Controls.MaterialProgressBar prbStatus;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialListView listVideo;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
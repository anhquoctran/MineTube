namespace YoutubeApisDemo
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.playerVideo = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.playerVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // playerVideo
            // 
            this.playerVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerVideo.Enabled = true;
            this.playerVideo.Location = new System.Drawing.Point(0, 0);
            this.playerVideo.Name = "playerVideo";
            this.playerVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerVideo.OcxState")));
            this.playerVideo.Size = new System.Drawing.Size(464, 281);
            this.playerVideo.TabIndex = 0;
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.playerVideo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "VideoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.playerVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 playerVideo;
    }
}
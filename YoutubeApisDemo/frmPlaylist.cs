using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace YoutubeApisDemo
{
    public partial class frmPlaylist : Form
    {
        public frmPlaylist()
        {
            InitializeComponent();
            TitleCol = new ColumnHeader();
            UrlCol = new ColumnHeader();
            DurationCol = new ColumnHeader();
            PublishedDateCol = new ColumnHeader();
            lstVideos.Columns.AddRange(new ColumnHeader[] { TitleCol, DurationCol, PublishedDateCol, UrlCol});
            TitleCol.Text = "Title";
            UrlCol.Text = "URL";
            DurationCol.Text = "Duration";
            PublishedDateCol.Text = "Date Published";
            lblTitle.Text = Text;
        }

        ColumnHeader TitleCol;
        ColumnHeader UrlCol;
        ColumnHeader DurationCol;
        ColumnHeader PublishedDateCol;

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetPlaylistInfo(txtboxUrl.Text);
        }

        private void GetPlaylistInfo(string inputId)
        {
            lstVideos.Items.Clear();

            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", "Error");
            }
            else
            {
                YoutubeVideo[] videos = YoutubeApis.GetPlaylistInfo(inputId);
                foreach (var video in videos)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(video.Title);
                    item.SubItems.Add(video.Duration);
                    item.SubItems.Add(video.DatePublished.ToString());
                    item.SubItems.Add(video.Url);

                    lstVideos.Items.AddRange(new ListViewItem[] { item });
                }
            }          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            Close();
        }

        //OLVColumn ThumbCol;
        //OLVColumn InfoCol;
    }
}

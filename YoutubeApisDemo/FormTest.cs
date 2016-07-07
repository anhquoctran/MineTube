using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeApisDemo
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();

            GetPlaylistInfo("PL0EE421AE8BCEBA4A");

        }
        private void GetPlaylistInfo(string inputId)
        {
         
            if (inputId == "")
            {
                MessageBox.Show("Required field is not null!", "Error");
            }
            else
            {
                 

                YoutubeVideo[] videos = YouTubeApis.GetVideoOfPlaylist(inputId);

                foreach (var video in videos)
                {
                    var data = new[]
                    {
                        new [] {video.Title, video.Duration, video.ChannelTitle, video.View.Value.ToString("N0"), video.CommentCount.Value.ToString("N0"), video.Quality, video.Like.Value.ToString("N0"), video.Dislike.Value.ToString("N0"), "https://www.youtube.com/watch?v=" + video.Id, video.ChannelId}
                    };
                    foreach (var content in data)
                    {
                        var item = new ListViewItem(content);
                       
                    }

                }
               
            }
        }
    }
}

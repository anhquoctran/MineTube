using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApisDemo
{
    public class YoutubePlaylist
    {
        public YoutubePlaylist(string playlistId)
        {
            Id = playlistId;
            YoutubeApis.GetPlaylistInfo(this);
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ChannelTitle { get; set; }
        public string[] Tags { get; set; }
        public string PrivacyStatus { get; set; }
    }
}

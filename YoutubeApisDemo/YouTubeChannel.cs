using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApisDemo
{
    public class YouTubeChannel
    {
        public ulong? VideoCounter { get; set; }
        public ulong? SubscribeCounter { get; set; }
        public ulong? ViewCounter { get; set; }
        public ulong? CommentCounter { get; set; }

        /// <summary>
        /// Get or set name of current channel by ChannelID
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Get or set name of avatar channel url
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Get or set cover photo channel url
        /// </summary>
        public string CoverPhotoUrl { get; set; }

        /// <summary>
        /// Get or set channel ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Create an instance of YouTube Channel type
        /// </summary>
        /// <param name="ID"></param>
        public YouTubeChannel(string ID)
        {
            //YoutubeApis.GetChannelInfo(this);
        }
    }
}

using System;
using System.Drawing;
using Google.Apis.YouTube.v3.Data;
using System.Collections.Generic;

namespace MineTube
{
    public class YoutubeVideo
    {
        /// <summary>
        /// Gets or sets YouTube video ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets YouTube video Title. This is file name for download and save using for offline.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets YouTube video description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets YouTube channel/publisher name.
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// Gets or sets YouTube channel/publisher ID.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets YouTube video URL.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets dimension of video as string.
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// Gets or sets quality of YouTube video (SD or HD).
        /// </summary>
        public string Quality { get; set; }

        /// <summary>
        /// Gets or sets category of video.
        /// </summary>
        public string CategoryId { get; set;}

        /// <summary>
        /// Gets or sets views count of video.
        /// </summary>
        public ulong? View { get; set; }

        /// <summary>
        /// Gets or sets likes count of video.
        /// </summary>
        public ulong? Like { get; set; }

        /// <summary>
        /// Gets or sets dislikes count of video.
        /// </summary>
        public ulong? Dislike { get; set; }

        /// <summary>
        /// Gets or sets comments count of video.
        /// </summary>
        public ulong? CommentCount { get; set; }

        /// <summary>
        /// Gets or sets published date of video.
        /// </summary>
        public DateTime DatePublished { get; set; }

        /// <summary>
        /// Gets or sets video thumbnail URL.
        /// </summary>
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Gets or sets video duration.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets video download link.
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets all collections of video tags.
        /// </summary>
        public string[] VideoTags { get; set; }

        /// <summary>
        /// Gets or sets file extension for save or download.
        /// </summary>
        public string VideoExtension { get; set; }

        /// <summary>
        /// Gets or sets Video dimension as width and height.
        /// </summary>
        public Size VideoDimension { get; set; }
        /// <summary>
        /// Create a YouTube Video Instance with Video ID and get information of this.
        /// </summary>
        /// <param name="VideoID"></param>            
        public YoutubeVideo(string VideoID)
        {
            Id = VideoID;
            YouTubeApis.GetVideoInfo(this);
        }  

        public YoutubeVideo()
        {
            
        }

        public override string ToString()
        {
            return VideoExtension + " File " + VideoDimension.Width.ToString() + " x " + VideoDimension.Height.ToString();
        }

        public void SetQuality(string Extension, Size Dimension)
        {
            VideoDimension = Dimension;
            VideoExtension = Extension;
        }

        
    }
}
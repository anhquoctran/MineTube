using System;
using System.Drawing;
using Google.Apis.YouTube.v3.Data;
using System.Collections.Generic;

namespace YoutubeApisDemo
{
    public class YoutubeVideo
    {
        public string Id, Title, Description, ChannelTitle, ChannelId, Url, Dimension, Quality;
        public ulong? View, Like, Dislike, CommentCount;
        public DateTime DatePublished;
        public string Thumb;
        public string Duration;
        
        public string[] VideoTags;
        
        public YoutubeVideo(string VideoId)
        {
            Id = VideoId;
            YoutubeApis.GetVideoInfo(this);
        }
    }
}
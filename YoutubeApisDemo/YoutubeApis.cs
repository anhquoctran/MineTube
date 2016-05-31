﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using System.IO;
using System.Threading;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;

namespace YoutubeApisDemo
{
    public class YoutubeApis
    {
        private static YouTubeService ytService = Auth();

        private static YouTubeService Auth()
        {
            UserCredential creds;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                creds = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }, "user", CancellationToken.None, new FileDataStore("YoutubeApiDemo")).Result;

                var services = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = creds, ApplicationName = "YoutubeApiDemo"
                });

                return services;
            }
        }

        public static void GetVideoInfo(YoutubeVideo video)
        {
            try
            {
                var videoRequest = ytService.Videos.List("snippet");
                videoRequest.Id = video.Id;

                var request = ytService.Videos.List("statistics");
                request.Id = video.Id;
                var response1 = request.Execute();

                var response = videoRequest.Execute();

                var request2 = ytService.Videos.List("contentDetails");
                request2.Id = video.Id;
                var response2 = request2.Execute();

                if (response1.Items.Count > 0)
                {
                    video.CommentCount = response1.Items[0].Statistics.CommentCount;
                    video.View = response1.Items[0].Statistics.ViewCount;
                    video.Like = response1.Items[0].Statistics.LikeCount;
                    video.Dislike = response1.Items[0].Statistics.DislikeCount;
                    
                }

                if (response.Items.Count > 0)
                {
                    video.Title = response.Items[0].Snippet.Title;
                    video.Description = response.Items[0].Snippet.Description;
                    video.DatePublished = response.Items[0].Snippet.PublishedAt.Value;
                    video.ChannelTitle = response.Items[0].Snippet.ChannelTitle;
                    video.Thumb = response.Items[0].Snippet.Thumbnails.High.Url;
                    video.ChannelId = response.Items[0].Snippet.ChannelId;

                    if (response.Items[0].Snippet.Tags != null)
                    {
                        video.VideoTags = new string[response.Items[0].Snippet.Tags.Count];
                        response.Items[0].Snippet.Tags.CopyTo(video.VideoTags, 0);
                    }
                    else
                    {
                        video.VideoTags = new string[] { "Không có thẻ nào" };
                    }
                }
                if (response2.Items.Count > 0)
                {
                    video.Dimension = response2.Items[0].ContentDetails.Dimension.ToUpper();
                    video.Quality = response2.Items[0].ContentDetails.Definition.ToUpper();
                    string s = response2.Items[0].ContentDetails.Duration;
                    TimeSpan ts = XmlConvert.ToTimeSpan(s);
                    video.Duration = ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể tìm thấy video!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }
}

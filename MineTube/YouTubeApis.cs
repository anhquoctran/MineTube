using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using VideoLibrary;

namespace MineTube
{
    public class YouTubeApis
    {
        private static YouTubeService ytService = Auth();        

        private static YouTubeService Auth()
        {
            try
            {
                UserCredential creds;
                using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    creds = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets, new[] { YouTubeService.Scope.YoutubeReadonly }, "user", CancellationToken.None, new FileDataStore("YoutubeApiDemo")).Result;

                    var services = new YouTubeService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = creds,
                        ApplicationName = "YoutubeApiDemo"
                    });
                    return services;
                    
                }
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }
        
        }
        static int PlaylistTotalResult = 0;
        public static void GetPlaylistInformation(YouTubePlaylist playlist)
        {
            try
            {
                var playlistRquest = ytService.Playlists.List("snippet");
                playlistRquest.Id = playlist.Id;
                var result = playlistRquest.Execute();
                if (result.Items.Count > 0 )
                {
                    playlist.PlaylistTitle = result.Items[0].Snippet.Title;
                    playlist.Thumbs = result.Items[0].Snippet.Thumbnails.Medium.Url;
                    playlist.OwnerID = result.Items[0].Snippet.ChannelId;
                    playlist.DatePublished = result.Items[0].Snippet.PublishedAt.Value;
                    playlist.Description = result.Items[0].Snippet.Description;
                    playlist.TotalResults = PlaylistTotalResult;
                    playlist.OwnerTitle = result.Items[0].Snippet.ChannelTitle;
                    playlist.NextPageToken = result.NextPageToken;
                    playlist.PrevPageToken = result.PrevPageToken;
                }
            }
            catch (AggregateException ex)
            {
                foreach(var e in ex.InnerExceptions)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static YoutubeVideo[] GetVideoOfPlaylist(string IdPlaylist)
        {
            YoutubeVideo[] videosResults = null;
            try
            {
                var playlistRequest = ytService.PlaylistItems.List("contentDetails,snippet");
                playlistRequest.PlaylistId = IdPlaylist;
                playlistRequest.MaxResults = 50;
                
                var playlistResponse = playlistRequest.Execute();
                
                videosResults = new YoutubeVideo[playlistResponse.Items.Count];
                int i = 0;
                foreach (var item in playlistResponse.Items)
                {
                    videosResults[i++] = new YoutubeVideo(item.ContentDetails.VideoId);
                }

                PlaylistTotalResult = playlistResponse.PageInfo.TotalResults.Value;
           }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    MessageBox.Show(e.Message, Application.ProductName);
                }               
            }
            return videosResults;
        }

        public static void GetChannelInfo(YouTubeChannel channel)
        {
            try
            {
                var StatisticsRequest = ytService.Channels.List("statistics,status,brandingSettings,snippet");
                StatisticsRequest.Id = channel.Id;
                var Response = StatisticsRequest.Execute();

                if (Response.Items.Count > 0)
                {
                    channel.SubscribeCounter = Response.Items[0].Statistics.SubscriberCount;
                    channel.VideoCounter = Response.Items[0].Statistics.VideoCount;
                    channel.ViewCounter = Response.Items[0].Statistics.ViewCount;
                    channel.CommentCounter = Response.Items[0].Statistics.CommentCount;
                    channel.IsLinked = Response.Items[0].Status.IsLinked;
                    channel.CoverPhotoUrl = Response.Items[0].BrandingSettings.Image.BannerImageUrl;
                    channel.ChannelName = Response.Items[0].Snippet.Title;
                    channel.AvatarUrl = Response.Items[0].Snippet.Thumbnails.Medium.Url;
                }              
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void GetVideoInfo(YoutubeVideo video)
        {
            try
            {
                
                var videoRequest = ytService.Videos.List("snippet,statistics,contentDetails");
                videoRequest.Id = video.Id;

                var response = videoRequest.Execute();                

                if (response.Items.Count > 0)
                {
                    if (response.Items[0].Statistics.CommentCount == null)
                    {
                        video.CommentCount = 0;
                    }
                    else
                    {
                        video.CommentCount = response.Items[0].Statistics.CommentCount;
                    }

                    if (response.Items[0].Statistics.ViewCount == null)
                    {
                        video.View = 0;
                    }
                    else
                    {
                        video.View = video.View = response.Items[0].Statistics.ViewCount;
                    }

                    if (response.Items[0].Statistics.LikeCount == null)
                    {
                        video.Like = 0;
                    }
                    else
                    {
                        video.Like = response.Items[0].Statistics.LikeCount;
                    }

                    if (response.Items[0].Statistics.DislikeCount == null)
                    {
                        video.Dislike = 0;
                    }
                    else
                    {
                        video.Dislike = response.Items[0].Statistics.DislikeCount;
                    }
                    
                    video.Title = response.Items[0].Snippet.Title;
                    video.Description = response.Items[0].Snippet.Description;
                    video.DatePublished = response.Items[0].Snippet.PublishedAt.Value;
                    video.ChannelTitle = response.Items[0].Snippet.ChannelTitle;
                    video.ThumbUrl = response.Items[0].Snippet.Thumbnails.High.Url;
                    video.ChannelId = response.Items[0].Snippet.ChannelId;
                    video.CategoryId = response.Items[0].Snippet.CategoryId;
                    video.Url = "https://www.youtube.com/watch?v=" + video.Id;
                    //var size = response.Items[0].FileDetails.FileType;
                    if (response.Items[0].Snippet.Tags != null)
                    {
                        video.VideoTags = new string[response.Items[0].Snippet.Tags.Count];
                        response.Items[0].Snippet.Tags.CopyTo(video.VideoTags, 0);
                    }
                    else
                    {
                        video.VideoTags = new string[] { "Không có thẻ nào" };
                    }
                    
                    video.Dimension = response.Items[0].ContentDetails.Dimension.ToUpper();
                    video.Quality = response.Items[0].ContentDetails.Definition.ToUpper();
                    string s = response.Items[0].ContentDetails.Duration;
                    TimeSpan ts = XmlConvert.ToTimeSpan(s);
                    video.Duration = FormatTime(ts);              
                }              
                else
                {
                    MessageBox.Show("Không thể tìm thấy video!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FormatTime(TimeSpan inputTime)
        {
            return inputTime.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace YoutubeApisDemo
{
    public class YouTubeDownloader
    {
        public static List<string> ExtractUrls(string html)
        {
            html = Uri.EscapeDataString(Regex.Match(html, "url_encoded_fmt_stream_map=(.+?)&", RegexOptions.Singleline).Groups[1].ToString());
            MatchCollection matchs = Regex.Matches(html, "url=(.+?)&quality=(.+?)&fallback_host=(.+?)&type=(.+?)&itag=(.+?),", RegexOptions.Singleline);

            bool firstTry = matchs.Count > 0;

            if (!firstTry)
            {
                matchs = Regex.Matches(html, "itag=(.+?)&url=(.+?)&type=(.+?)&fallback_host=(.+?)&sig=(.+?)&quality=(.+?),{0,1}", RegexOptions.Singleline);                
            }

            List<string> urls = new List<string>();

            foreach (Match match in matchs)
            {
                if (firstTry)
                    urls.Add(Uri.UnescapeDataString(match.Groups[1] + ""));
                else urls.Add(Uri.UnescapeDataString(match.Groups[2] + "") + "&signature=" + match.Groups[5]);
            }

            return urls;
        }

        public static bool GetQuality(YoutubeVideo q)
        {
            if (q.DownloadUrl.Contains("itag=5"))
                q.SetQuality("flv", new Size(320, 240));
            else if (q.DownloadUrl.Contains("itag=34"))
                q.SetQuality("flv", new Size(400, 226));
            else if (q.DownloadUrl.Contains("itag=6"))
                q.SetQuality("flv", new Size(480, 360));
            else if (q.DownloadUrl.Contains("itag=35"))
                q.SetQuality("flv", new Size(640, 380));
            else if (q.DownloadUrl.Contains("itag=18"))
                q.SetQuality("mp4", new Size(480, 360));
            else if (q.DownloadUrl.Contains("itag=22"))
                q.SetQuality("mp4", new Size(1280, 720));
            else if (q.DownloadUrl.Contains("itag=37"))
                q.SetQuality("mp4", new Size(1920, 1280));
            else if (q.DownloadUrl.Contains("itag=38"))
                q.SetQuality("mp4", new Size(4096, 72304));
            else return false;
            return true;
        }
    }
}

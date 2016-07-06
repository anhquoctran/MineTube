using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApisDemo
{
    public class YouTubePlaylists
    {
        public YouTubePlaylists(string playlistId)
        {
            Id = playlistId;
        }

        public string Id { get; set; }
        public int MaxResult { get; set; }
        public int TotalResults { get; set; }
        public int ResultPerPage { get; set; }
        public string PageToken { get; set; }
    }
}

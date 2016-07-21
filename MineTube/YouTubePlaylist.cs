using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineTube
{
    public class YouTubePlaylist
    {
        public YouTubePlaylist(string playlistId)
        {
            Id = playlistId;
            YouTubeApis.GetPlaylistInformation(this);
        }

        public string Id { get; set; }
        public int MaxResult { get; set; }
        public int TotalResults { get; set; }
        public int ResultPerPage { get; set; }
        public string PlaylistTitle { get; set; }
        public string OwnerID { get; set; }
        public string OwnerTitle { get; set; }
        public string Thumbs { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; }
        public string NextPageToken { get; set; }
        public string PrevPageToken { get; set; }
    }
}

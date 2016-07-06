using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApisDemo
{
    public interface IYouTubeSong
    {
        string Publisher { get; set; }
        string VideoId { get; set; }
        string Title { get; set; }
        string PlaylistId { get; set; }
        ulong? Duration { get; set; }
        Guid SongGuid { get; set; }

        
    }
}

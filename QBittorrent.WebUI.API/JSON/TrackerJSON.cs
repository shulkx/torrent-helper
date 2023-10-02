using System;

namespace QBittorrent.WebUI.API.JSON
{
    internal class TrackerJSON
    {
        public Uri Url { get; set; }
        public string Status { get; set; }
        public int Num_Peers { get; set; }
        public string Msg { get; set; }
    }
}

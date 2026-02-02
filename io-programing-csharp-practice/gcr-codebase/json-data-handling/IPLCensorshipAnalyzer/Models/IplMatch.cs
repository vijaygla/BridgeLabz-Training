using System.Collections.Generic;

namespace IPLCensorshipAnalyzer.Models
{
    public class IplMatch
    {
        public int MatchId { get; set; }
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }
        public Dictionary<string, int>? Score { get; set; }
        public string? Winner { get; set; }
        public string? PlayerOfMatch { get; set; }
    }
}

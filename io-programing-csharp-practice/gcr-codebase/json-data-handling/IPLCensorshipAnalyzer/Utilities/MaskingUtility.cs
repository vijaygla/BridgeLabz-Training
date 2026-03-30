namespace IPLCensorshipAnalyzer.Utilities
{
    public static class MaskingUtility
    {
        public static string MaskTeamName(string team)
        {
            var parts = team.Split(' ');
            return parts.Length > 1 ? parts[0] + " ***" : team;
        }
    }
}

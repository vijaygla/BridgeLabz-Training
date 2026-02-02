using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using IPLCensorshipAnalyzer.Models;
using IPLCensorshipAnalyzer.Utilities;

namespace IPLCensorshipAnalyzer.Processors
{
    public class IplJsonProcessor
    {
        public static void ProcessJson()
        {
            try
            {
                string jsonPath = Path.Combine("Data", "ipl.json");
                string censoredJsonPath = Path.Combine("Data", "ipl_censored.json");

                if (!File.Exists(jsonPath))
                {
                    Console.WriteLine($"Error: File not found at {jsonPath}");
                    return;
                }

                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    }
                };

                var matches = JsonConvert.DeserializeObject<List<IplMatch>>(
                    File.ReadAllText(jsonPath), settings);

                if (matches != null)
                {
                    foreach (var m in matches)
                    {
                        if (m.Team1 != null) m.Team1 = MaskingUtility.MaskTeamName(m.Team1);
                        if (m.Team2 != null) m.Team2 = MaskingUtility.MaskTeamName(m.Team2);
                        if (m.Winner != null) m.Winner = MaskingUtility.MaskTeamName(m.Winner);
                        m.PlayerOfMatch = "REDACTED";

                        var newScore = new Dictionary<string, int>();
                        if (m.Score != null)
                        {
                            foreach (var s in m.Score)
                                newScore[MaskingUtility.MaskTeamName(s.Key)] = s.Value;
                        }
                        m.Score = newScore;
                    }

                    File.WriteAllText(censoredJsonPath,
                        JsonConvert.SerializeObject(matches, new JsonSerializerSettings
                        {
                            ContractResolver = new DefaultContractResolver
                            {
                                NamingStrategy = new SnakeCaseNamingStrategy()
                            },
                            Formatting = Formatting.Indented
                        }));
                    Console.WriteLine("JSON processing complete.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during JSON processing: {ex.Message}");
            }
        }
    }
}

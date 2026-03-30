using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using EventTracker.Core.Models;

namespace EventTracker.Core.Services
{
    // Handles JSON log creation
    public class AuditLogger
    {
        private const string LogFile = "logs/audit-log.json";

        public static void Log(AuditLog log)
        {
            List<AuditLog> logs = new();

            // Read existing logs if file exists
            if (File.Exists(LogFile))
            {
                string existingData = File.ReadAllText(LogFile);
                if (!string.IsNullOrEmpty(existingData))
                {
                    logs = JsonSerializer.Deserialize<List<AuditLog>>(existingData);
                }
            }

            logs.Add(log);

            // Write logs back as formatted JSON
            File.WriteAllText(
                LogFile,
                JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true })
            );
        }
    }
}

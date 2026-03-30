using System;

namespace EventTracker.Core.Models
{
    // Model representing one audit event
    public class AuditLog
    {
        public string EventName { get; set; }
        public string MethodName { get; set; }
        public DateTime Timestamp { get; set; }
        public string PerformedBy { get; set; }
    }
}

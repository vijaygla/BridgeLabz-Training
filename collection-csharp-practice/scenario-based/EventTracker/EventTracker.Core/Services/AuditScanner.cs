using System;
using System.Reflection;
using EventTracker.Core.Attributes;
using EventTracker.Core.Models;

namespace EventTracker.Core.Services
{
    // Uses Reflection to scan & invoke audited methods
    public class AuditScanner
    {
        public static void Execute(object obj, string methodName)
        {
            MethodInfo method = obj.GetType().GetMethod(methodName);

            if (method == null) return;

            // Check if method has AuditTrail attribute
            var attribute = method.GetCustomAttribute<AuditTrailAttribute>();

            // Execute actual method
            method.Invoke(obj, null);

            // If annotated, log audit
            if (attribute != null)
            {
                AuditLogger.Log(new AuditLog
                {
                    EventName = attribute.EventName,
                    MethodName = method.Name,
                    Timestamp = DateTime.Now,
                    PerformedBy = Environment.UserName
                });
            }
        }
    }
}

using System;

namespace EventTracker.Core.Attributes
{
    // Custom Annotation (Attribute)
    // Used to mark methods that need auditing
    [AttributeUsage(AttributeTargets.Method)]
    public class AuditTrailAttribute : Attribute
    {
        public string EventName { get; }

        public AuditTrailAttribute(string eventName)
        {
            EventName = eventName;
        }
    }
}

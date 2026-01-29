using System;

namespace HealthCheckPro.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class PublicApiAttribute : Attribute
    {
        public string Description { get; }

        public PublicApiAttribute(string description)
        {
            Description = description;
        }
    }
}

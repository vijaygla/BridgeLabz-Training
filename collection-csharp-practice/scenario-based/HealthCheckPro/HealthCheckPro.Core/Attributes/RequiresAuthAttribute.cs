using System;

namespace HealthCheckPro.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RequiresAuthAttribute : Attribute
    {
    }
}

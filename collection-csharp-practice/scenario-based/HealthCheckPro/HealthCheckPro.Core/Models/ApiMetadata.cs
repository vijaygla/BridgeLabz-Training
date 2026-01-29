namespace HealthCheckPro.Core.Models
{
    // Model used for API documentation metadata
    public class ApiMetadata
    {
        public required string Controller { get; set; }
        public required string Method { get; set; }
        public bool IsPublic { get; set; }
        public bool RequiresAuthentication { get; set; }
        public required string Description { get; set; }
    }
}

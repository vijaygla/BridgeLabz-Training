using HealthCheckPro.Core.Attributes;

namespace HealthCheckPro.Core.Controllers
{
    public class LabTestController
    {
        [PublicApi("Fetch all available lab tests")]
        public void GetLabTests()
        {
            // This method is intentionally left empty. Consider implementing it or throwing a NotSupportedException.
            throw new NotSupportedException();
        }

        [PublicApi("Upload lab test results")]
        [RequiresAuth]
        public void UploadResults()
        {
            // This method is intentionally left empty. Consider implementing it or throwing a NotSupportedException.
            throw new NotSupportedException();
        }
    }
}

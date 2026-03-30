using HealthCheckPro.Core.Attributes;

namespace HealthCheckPro.Core.Controllers
{
    public class PatientController
    {
        [PublicApi("Get patient information")]
        [RequiresAuth]
        public void GetPatient()
        {
            // This method is intentionally left empty. Consider implementing it or throwing a NotSupportedException.
            throw new NotSupportedException();
        }

        // Missing annotation - intentionally
        public static void DeletePatient()
        {
            // This method is intentionally left empty. Consider implementing it or throwing a NotSupportedException.
            throw new NotSupportedException();
        }
    }
}

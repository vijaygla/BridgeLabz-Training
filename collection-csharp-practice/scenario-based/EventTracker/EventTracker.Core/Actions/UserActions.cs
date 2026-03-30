using System;
using EventTracker.Core.Attributes;

namespace EventTracker.Core.Actions
{
    // Business actions performed by user
    public class UserActions
    {
        [AuditTrail("User Login")]
        public void Login()
        {
            Console.WriteLine("User logged in successfully.");
        }

        [AuditTrail("File Upload")]
        public void UploadFile()
        {
            Console.WriteLine("File uploaded.");
        }

        [AuditTrail("File Deletion")]
        public void DeleteFile()
        {
            Console.WriteLine("File deleted.");
        }
    }
}

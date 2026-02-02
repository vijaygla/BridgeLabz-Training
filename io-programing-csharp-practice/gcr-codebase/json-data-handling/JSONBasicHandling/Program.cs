using System;
using JSONBasicHandling.Demos;

namespace JSONBasicHandling
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("--- CarToJson Demo ---");
            CarToJson.Run();
            Console.WriteLine("\n--- FilterAgeAbove25 Demo ---");
            FilterAgeAbove25.Run();
            Console.WriteLine("\n--- JsonSchemaValidation Demo ---");
            JsonSchemaValidation.Run();
            Console.WriteLine("\n--- MergeJsonObjects Demo ---");
            MergeJsonObjects.Run();
            Console.WriteLine("\n--- StudentJsonDemo Demo ---");
            StudentJsonDemo.Run();
        }
    }
}

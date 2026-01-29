using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using HealthCheckPro.Core.Attributes;
using HealthCheckPro.Core.Models;

namespace HealthCheckPro.Core.Scanner
{
    public class ApiMetadataScanner
    {
        protected ApiMetadataScanner() { }

        private const string DocsPath = "docs/api-docs.json";

        public static void ScanAndGenerateDocs()
        {
            List<ApiMetadata> apiList = new();

            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (!type.Name.EndsWith("Controller"))
                    continue;

                foreach (var method in type.GetMethods(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    var publicApi =
                        method.GetCustomAttribute<PublicApiAttribute>();
                    var auth =
                        method.GetCustomAttribute<RequiresAuthAttribute>();

                    if (publicApi == null)
                    {
                        Console.WriteLine(
                            $"⚠ WARNING: {type.Name}.{method.Name} missing [PublicAPI]");
                    }

                    apiList.Add(new ApiMetadata
                    {
                        Controller = type.Name,
                        Method = method.Name,
                        IsPublic = publicApi != null,
                        RequiresAuthentication = auth != null,
                        Description = publicApi?.Description ?? "N/A"
                    });
                }
            }

            Directory.CreateDirectory("docs");

            File.WriteAllText(
                DocsPath,
                JsonSerializer.Serialize(
                    apiList,
                    new JsonSerializerOptions { WriteIndented = true }));

            Console.WriteLine("\n✅ API documentation generated successfully.");
        }
    }
}

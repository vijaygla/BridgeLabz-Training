using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONBasicHandling.Demos
{
    public class JsonSchemaValidation
    {
        public static void Run()
        {
            string schemaJson = @"{
          'type':'object',
          'properties':{
            'email':{'type':'string','format':'email'}
          }
        }";

            JSchema schema = JSchema.Parse(schemaJson);
            JObject data = JObject.Parse(@"{ 'email':'test@gmail.com' }");

            Console.WriteLine(data.IsValid(schema));
        }
    }
}

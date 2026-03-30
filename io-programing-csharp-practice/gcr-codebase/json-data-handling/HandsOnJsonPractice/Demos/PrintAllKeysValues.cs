using System;
using Newtonsoft.Json.Linq;

namespace HandsOnJsonPractice.Demos
{
    public class PrintAllKeysValues
    {
        public void PrintKeysAndValues()
        {
            JObject obj = JObject.Parse(@"{ 'name':'Raj', 'age':30 }");

            foreach (var prop in obj.Properties())
                Console.WriteLine($"{prop.Name} : {prop.Value}");
        }
    }
}

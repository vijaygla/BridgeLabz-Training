using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace JSONBasicHandling.Demos
{
    public class FilterAgeAbove25
    {
        public static void Run()
        {
            string json = @"[
            { 'name':'A', 'age':20 },
            { 'name':'B', 'age':30 }
        ]";

            JArray arr = JArray.Parse(json);

            var names = arr.Where(p => p.Value<int?>("age") > 25)
                           .Select(p => p["name"]);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
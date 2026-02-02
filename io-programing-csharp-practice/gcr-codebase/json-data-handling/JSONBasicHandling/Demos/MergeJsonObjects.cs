using System;
using Newtonsoft.Json.Linq;

namespace JSONBasicHandling.Demos
{
    public class MergeJsonObjects
    {
        public static void Run()
        {
            JObject obj1 = JObject.Parse(@"{ 'name':'A' }");
            JObject obj2 = JObject.Parse(@"{ 'age':25 }");

            obj1.Merge(obj2);
            Console.WriteLine(obj1.ToString());
        }
    }
}
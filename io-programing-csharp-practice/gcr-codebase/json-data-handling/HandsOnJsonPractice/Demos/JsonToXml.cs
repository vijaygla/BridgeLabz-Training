using System;
using Newtonsoft.Json;

namespace HandsOnJsonPractice.Demos
{
    public class JsonToXml
    {
        public void ConvertJsonToXml()
        {
            string json = @"{ 'person': { 'name':'A', 'age':30 } }";
            var xml = JsonConvert.DeserializeXNode(json, "Root");
            Console.WriteLine(xml);
        }
    }
}

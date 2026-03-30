using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace HandsOnJsonPractice.Demos
{
    public class ReadJsonExtractFields
    {
        public void ReadAndExtract()
        {
            var json = File.ReadAllText("Data/user.json");
            var arr = JArray.Parse(json);

            foreach (var u in arr)
                Console.WriteLine($"{u["name"]} - {u["email"]}");
        }
    }
}

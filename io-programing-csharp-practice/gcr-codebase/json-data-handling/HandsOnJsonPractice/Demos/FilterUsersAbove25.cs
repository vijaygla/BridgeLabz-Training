using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace HandsOnJsonPractice.Demos
{
    public class FilterUsersAbove25
    {
        public void FilterUsers()
        {
            var json = File.ReadAllText("Data/user.json");
            var arr = JArray.Parse(json);

            foreach (var u in arr)
                if (u.Value<int>("age") > 25)
                    Console.WriteLine(u["name"]);
        }
    }
}

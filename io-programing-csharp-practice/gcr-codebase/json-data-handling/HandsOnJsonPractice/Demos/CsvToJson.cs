using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace HandsOnJsonPractice.Demos
{
    public class CsvToJson
    {
        public void ConvertCsvToJson()
        {
            var lines = File.ReadAllLines("Data/data.csv");
            var headers = lines[0].Split(',');

            var list = lines.Skip(1).Select(line =>
            {
                var values = line.Split(',');
                return headers.Zip(values, (header, value) => new { header, value })
                              .ToDictionary(x => x.header, x => x.value);
            });

            Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
        }
    }
}

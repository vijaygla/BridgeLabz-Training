using System;
using Newtonsoft.Json;
using JSONBasicHandling.Models;

namespace JSONBasicHandling.Demos
{
    public class CarToJson
    {
        public static void Run()
        {
            Car car = new Car { Brand = "Tesla", Year = 2024 };
            Console.WriteLine(JsonConvert.SerializeObject(car, Formatting.Indented));
        }
    }
}
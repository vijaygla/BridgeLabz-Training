using System;
using HandsOnJsonPractice.Demos;

namespace HandsOnJsonPractice
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("HandsOnJsonPractice Project");

                Console.WriteLine("\nCsvToJson:");
                new CsvToJson().ConvertCsvToJson();

                Console.WriteLine("\nJsonToXml:");
                new JsonToXml().ConvertJsonToXml();

                Console.WriteLine("\nFilterUsersAbove25:");
                new FilterUsersAbove25().FilterUsers();

                Console.WriteLine("\nReadJsonExtractFields:");
                new ReadJsonExtractFields().ReadAndExtract();

                Console.WriteLine("\nPrintAllKeysValues:");
                new PrintAllKeysValues().PrintKeysAndValues();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

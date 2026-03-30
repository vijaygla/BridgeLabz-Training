using System;
using System.IO;
using System.Linq;

class SearchStudentRecordCsv
{
    static void Main(String[] args)
    {
        string searchName = "vijay";
        var lines = File.ReadAllLines("employees.csv").Skip(1);

        foreach(var line in lines)
        {
            var data = line.Split(',');
            if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Name: {data[1]}, Department: {data[2]}, Salary: {data[3]}");
            }
        }
    }
}

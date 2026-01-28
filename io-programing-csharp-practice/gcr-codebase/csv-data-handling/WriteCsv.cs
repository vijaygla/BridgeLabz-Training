using System.IO;

class WriteCsv
{
    static void Main()
    {
        string[] employees =
        {
            "ID,Name,Department,Salary",
            "1,John,IT,50000",
            "2,Alice,HR,45000",
            "3,Bob,IT,60000",
            "4,Eve,Finance,55000",
            "5,Tom,Sales,40000"
        };

        File.WriteAllLines("employees.csv", employees);
        Console.WriteLine("csv file created successfully");
    }
}

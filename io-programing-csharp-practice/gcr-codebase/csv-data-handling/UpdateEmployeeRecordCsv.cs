using System.IO;

class UpdateCsv
{
    static void Main()
    {
        var lines = File.ReadAllLines("employees.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            var data = lines[i].Split(',');
            if (data[2] == "IT")
            {
                double salary = double.Parse(data[3]);
                data[3] = (salary * 1.10).ToString();
                lines[i] = string.Join(",", data);
            }
        }

        File.WriteAllLines("employees_updated.csv", lines);
    }
}

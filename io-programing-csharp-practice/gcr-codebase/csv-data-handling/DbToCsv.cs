using System.Data.SqlClient;
using System.IO;

class DbToCsv
{
    static void Main()
    {
        using var con = new SqlConnection("connection_string");
        using var cmd = new SqlCommand("SELECT Id,Name,Dept,Salary FROM Employee", con);

        con.Open();
        using var reader = cmd.ExecuteReader();
        using var sw = new StreamWriter("employees.csv");

        sw.WriteLine("ID,Name,Department,Salary");

        while (reader.Read())
            sw.WriteLine($"{reader[0]},{reader[1]},{reader[2]},{reader[3]}");
    }
}

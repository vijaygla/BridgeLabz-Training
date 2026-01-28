using System.IO;
using System.Linq;

class MergeCsv
{
    static void Main()
    {
        var s1 = File.ReadAllLines("students.csv").Skip(1);
        var s2 = File.ReadAllLines("students2.csv").Skip(1);

        var merged = from a in s1.Select(l => l.Split(','))
                     join b in s2.Select(l => l.Split(','))
                     on a[0] equals b[0]
                     select $"{a[0]},{a[1]},{a[2]},{b[1]},{b[2]}";

        File.WriteAllLines("students_merged.csv",
            new[] { "ID,Name,Age,Marks,Grade" }.Concat(merged));
    }
}

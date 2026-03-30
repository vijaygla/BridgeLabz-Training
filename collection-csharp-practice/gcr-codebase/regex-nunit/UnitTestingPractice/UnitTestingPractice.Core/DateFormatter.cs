namespace UnitTestingPractice.Core;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        DateTime dt = DateTime.Parse(inputDate);
        return dt.ToString("dd-MM-yyyy");
    }
}

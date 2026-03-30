namespace UnitTestingPractice.Core;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
        => File.WriteAllText(filename, content);

    public string ReadFromFile(string filename)
        => File.ReadAllText(filename);
}

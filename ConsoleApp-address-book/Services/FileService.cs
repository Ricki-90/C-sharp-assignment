using System.Dynamic;

namespace ConsoleApp_address_book.Services;

public class FileService
{
    public void Save(string filePath, string content)
    { 
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(content);
    }

    public string Read(string filePath) 
    {
        try
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        catch { return null!; }
    }
}

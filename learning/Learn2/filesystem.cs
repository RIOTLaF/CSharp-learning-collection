namespace learning.Learn2;
using System.IO;

public class File
{
    public void createfile()
    {
        System.IO.File.WriteAllText("test.txt", "ohai!\nhi again");
        string content = System.IO.File.ReadAllText("test.txt");
        
        Console.WriteLine($"path: {Directory.GetCurrentDirectory()}/test.txt");
        Console.WriteLine($"Content: {content}");
        Console.WriteLine($"Number of lines:{System.IO.File.ReadAllLines("test.txt").Length}");
    }
}
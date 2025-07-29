// using learning.Learn1;

namespace learning
{
    public class Program
    {
        static void Main()
        {
            Recursive();
        }
        
        static void Devprint(string text)
        {
            #if DEBUG
            Console.WriteLine(text);
            #endif
        }
            
        static void Recursive()
        {
            Console.WriteLine("Oh hi and welcome to my CSharp learning collection!");
            Console.WriteLine("ahem, let me introduce myself here, you can call me Assistant\nor any name you like");
            
            Console.WriteLine("\nSo let's start here, select any of your like\n");
            
            Console.WriteLine("Keybinds - 1\n??? - 2\n");
            Console.Write("Insert(ONLY INT NUMBERS): ");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out int newresult);

            if (result && newresult > 0 & newresult < 2)
            {
                var keybinds = new learning.Learn1.Keybinds();
                keybinds.DetectKeybinds();
                
                Devprint("\nyou can see the source code at Learn1/Keybinds.cs");
                Console.WriteLine("5 seconds before re-starting");
                Thread.Sleep(5000);
                Console.Clear();
                Recursive();
            }
        }
    }
}
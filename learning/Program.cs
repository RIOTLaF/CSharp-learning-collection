using System.Drawing;

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
            Console.Clear();
            
            Console.WriteLine("Oh hi and welcome to my CSharp learning collection!");
            new Debug.Colorize().ColoredText(ConsoleColor.Cyan, "ahem");
            Console.Write(", let me introduce myself here, you can call me Assistant\nor any name you like\n");
            
            Console.WriteLine("\nSo let's start here, select any of your like\n");
            
            Console.WriteLine("Keybinds - 1\nIt's a bool? - 2\n");
            Console.Write("Insert(ONLY INT NUMBERS): ");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out int newresult);

            if (result && newresult > 0 & newresult < 3)
            {
                if (newresult == 1)
                {
                    Console.Clear();
                    
                    var keybinds = new learning.Learn1.Keybinds();
                    keybinds.DetectKeybinds();
                
                    Devprint("\nyou can see the source code at Learn1/Keybinds.cs");
                    Console.WriteLine("5 seconds before re-starting");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Recursive();
                } else if (newresult == 2)
                {
                    Console.Clear();
                    
                    var condition = new learning.Learn1.Conditions();
                    condition.Condition();
                    
                    Devprint("\nyou can see the source code at Learn1/Conditions.cs");
                    Console.WriteLine("10 seconds before re-starting");
                    Thread.Sleep(10000);
                    Console.Clear();
                    Recursive();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That's not a valid input");
                
                Recursive();
            }
        }
    }
}
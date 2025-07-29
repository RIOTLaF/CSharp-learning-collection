namespace learning.Learn1;

public class Keybinds
{
     public void DetectKeybinds()
     {
          Console.WriteLine("Pizza is better than hamburger do you agree? (Y/N)\n");
          bool gotreply = false;
          while (!gotreply)
          {
               Thread.Sleep(200);
               var key = Console.ReadKey(true);
               if (key.Key == ConsoleKey.Y & key.Modifiers == ConsoleModifiers.None)
               {
                    Console.WriteLine("Thanks for agreeing with me");
                    gotreply = true;
               }
               else if (key.Key == ConsoleKey.N & key.Modifiers == ConsoleModifiers.None)
               {
                    Console.WriteLine("I Thought you was my friend...");
                    gotreply = true;
               }
          }
     }
}
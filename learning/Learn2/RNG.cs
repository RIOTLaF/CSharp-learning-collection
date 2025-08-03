namespace learning.Learn2;

public class RNG
{
    public void game_rng()
    {
        var random = new Random();
        int num = random.Next(0, 11);
        
        Console.WriteLine("Do you want to try to guess? 0-10");
        Console.WriteLine("Y/N\n");
        bool loop = true;
        bool reply = false;

        while (loop)
        {
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.N & input.Modifiers == ConsoleModifiers.None)
            {
                loop = false;
            }
            else if (input.Key == ConsoleKey.Y & input.Modifiers == ConsoleModifiers.None)
            {
                loop = false;
                reply = true;
            }
        }

        if (reply)
        {
            Console.WriteLine("Here we go! write a number below");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out int number);

            if (result)
            {
                if (number == num)
                {
                    Console.WriteLine($"Nice!, your number: {number}, the real one: {num}");
                }
                else
                {
                    Console.WriteLine($"Erm no, your number: {number}, the real one: {num}");
                }
            }
            else
            {
                Console.WriteLine($"Something went wrong {line} it's not numeric");
            }
        }
    }
}
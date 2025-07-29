using System;

namespace learning.Debug;

class Colorize
{
    public void ColoredText(System.ConsoleColor color, string text)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7.Classes.Numbering
{
    internal static class Number
    {
        public static void AddNumbering<T>(T Value, ConsoleColor Color)
        {
            ConsoleColor Temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine($"#{Value}");
            Console.ForegroundColor = Temp;
        }
    }
}

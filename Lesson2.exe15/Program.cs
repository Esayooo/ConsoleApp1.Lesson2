using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 100; x < 1000; x++) 
            {
                
                int hundreds = x / 100;
                int tens = (x / 10) % 10;
                int units = x % 10;

                int newNumber = hundreds * 10 + units;

                if (newNumber == 456)
                {
                    Console.WriteLine($"Число x равно {x}");
                    break; 
                }
            }

        }
    }
}

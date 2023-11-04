using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = 234;
            int weeks = days / 7;
            int remainingDays = days % 7;

            Console.WriteLine($"За {days} дней прошло {weeks} полных недель и {remainingDays} дней.");

        }
    }
}

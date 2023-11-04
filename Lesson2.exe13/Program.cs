using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanceInCentimeters = 250; 

            double meters = distanceInCentimeters / 100;

            Console.WriteLine($"Число полных метров: {meters} м");
        }
    }
}

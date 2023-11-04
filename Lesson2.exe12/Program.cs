using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe12
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double radius = 5.0;
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь круга: {area}");
        }
    }
}

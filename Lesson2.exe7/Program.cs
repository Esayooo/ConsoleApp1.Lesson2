using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius; // Радиус круга
            double side;   // Длина стороны квадрата

            // Задайте значения радиуса и стороны квадрата, например:
            radius = 5.0;
            side = 4.0;

            // Вычислите площади фигур
            double circleArea = Math.PI * Math.Pow(radius, 2);
            double squareArea = Math.Pow(side, 2);

            // Сравните площади и выведите результат
            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади круга и квадрата равны.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            double y = CalculateFunctionValue(x);

            Console.WriteLine($"Значение функции при x = {x} равно y = {y}");
        }

        static double CalculateFunctionValue(double x)
        {
            double y = x  + 7 * x + 10;
            return y;
        }
    }
}

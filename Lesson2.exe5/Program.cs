using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 28; // Замените 42 на ваше двузначное число

            // a. Найти число десятков
            int tens = number / 10;

            // b. Найти число единиц
            int units = number % 10;

            // c. Найти сумму цифр
            int sum = tens + units;

            // d. Найти произведение цифр
            int product = tens * units;

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {units}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");

        }
    }
}

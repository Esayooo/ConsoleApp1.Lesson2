using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a. Вывод всех целых чисел от 20 до 35
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            //b. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            Console.Write("Введите значение b (b > 10): ");
            int b = int.Parse(Console.ReadLine());

            if (b > 10)
            {
                for (int i = 10; i <= b; i++)
                {
                    int square = i * i;
                    Console.WriteLine(square);
                }
            }
            else
            {
                Console.WriteLine("Значение b должно быть больше 10.");
            }
            //c. Вывод третьих степеней всех целых чисел от a до 50 (a вводится с клавиатуры
            Console.Write("Введите значение a (a < 50): ");
            int a = int.Parse(Console.ReadLine());

            if (a < 50)
            {
                for (int i = a; i <= 50; i++)
                {
                    int cube = i * i * i;
                    Console.WriteLine(cube);
                }
            }
            else
            {
                Console.WriteLine("Значение a должно быть меньше 50.");
            }
            //d. Вывод всех целых чисел от a до b (a и b вводятся с клавиатуры):
            Console.Write("Введите значение a: ");
            int c= int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int d = int.Parse(Console.ReadLine());

            if (d > c)
            {
                for (int i = c; i <= d; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Значение b должно быть больше значения a.");
            }



        }
    }
}

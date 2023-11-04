using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeson2.exe16
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"До обмена: x = {x}, y = {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"После обмена: x = {x}, y = {y}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resultA = true || false; // A = Истина, B = Ложь
            Console.WriteLine("A или B: " + resultA); 
            bool resultB = true && false; // A = Истина, B = Ложь
            Console.WriteLine("A и B: " + resultB);
            bool resultC = false || false; // B = Ложь, C = Ложь
            Console.WriteLine("B или C: " + resultC); 




        }
    }
}

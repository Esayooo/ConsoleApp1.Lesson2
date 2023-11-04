using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U1 = 12.0; 
            double R1 = 6.0;  

            double U2 = 8.0;  
            double R2 = 4.0;  

            double I1 = U1 / R1;

            double I2 = U2 / R2;

            if (I1 < I2)
            {
                Console.WriteLine("Меньший ток протекает через первый участок.");
            }
            else if (I2 < I1)
            {
                Console.WriteLine("Меньший ток протекает через второй участок.");
            }
            else
            {
                Console.WriteLine("Токи через оба участка одинаковы.");
            }

        }
    }
}

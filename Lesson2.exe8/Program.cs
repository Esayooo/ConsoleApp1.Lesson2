using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double mass1, volume1, mass2, volume2;

           
            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;


            if (density1 > density2)
            {
                Console.WriteLine("Материал первого тела имеет большую плотность.");
            }
            else if (density2 > density1)
            {
                Console.WriteLine("Материал второго тела имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Материалы обоих тел имеют одинаковую плотность.");
            }
        }
    }
}

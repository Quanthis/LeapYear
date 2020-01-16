using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        { 
            int rok;
            Console.WriteLine("Tell me year you want to check: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
            Console.WriteLine("Year {0} is a leap year", rok);
            else Console.WriteLine("Year {0} is not a leap year", rok);

            Console.ReadKey(true);

        }
    }
}

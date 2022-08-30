using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Potens(3, 2));
            Console.WriteLine(Potens(6.2, 4));

            Console.ReadLine();

            double Potens(double tal, int exponent)
            {
                return Math.Pow(tal, exponent);
            }
        }
    }
}

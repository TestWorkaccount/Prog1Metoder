using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RitaRätvinkligTriangel(5);
            RitaRätvinkligTriangel(9);

            Console.ReadLine();

            
            void RitaRätvinkligTriangel(int sidlängd)
            {
                for(int i = 0; i < sidlängd; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

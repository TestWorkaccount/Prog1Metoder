using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summan är " + Addera(5, 10, 100) + " för Metoden Addera");


            Console.ReadLine();


            int Addera(int tal1, int tal2, int tal3)
            {
                return tal1 + tal2 + tal3;
            }
        }
    }
}

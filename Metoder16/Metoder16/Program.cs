using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meny");
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            Console.WriteLine("mata in ditt val:");

            string inmatat = Console.ReadLine();

            switch (inmatat)
            {
                case "1":
                    MenyvalAddera();
                    break;
                case "2":
                    MenyvalStörstaTalet();
                    break;
                case "3":
                    return;
                default:
                    return;
            }


            Console.ReadLine();

            void MenyvalAddera()
            {
                Console.WriteLine("Mata in tal1");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Mata in tal2");
                int tal2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Mata in tal3");
                int tal3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Summan är " + Addera(tal1, tal2, tal3));
            }

            void MenyvalStörstaTalet()
            {
                Console.WriteLine("Mata in tal1");
                int tal4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Mata in tal2");
                int tal5 = int.Parse(Console.ReadLine());
                Console.WriteLine("Det största talet är " + Störst(tal4, tal5));
            }

            int Störst(int tal1, int tal2)
            {
                if (tal1 >= tal2)
                {
                    return tal1;
                }
                else
                {
                    return tal2;
                }
            }

            int Addera(int tal1, int tal2, int tal3)
            {
                return tal1 + tal2 + tal3;
            }


        }
    }
}

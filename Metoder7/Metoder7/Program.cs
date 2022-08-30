using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Menyval:");
            Console.WriteLine("*******************");
            Console.WriteLine("1. Multiplicera två flyttal");
            Console.WriteLine("2. Dividera två flyttal");
            Console.WriteLine("3. Längsta strängen");
            Console.WriteLine("4. Avsluta programmet");
            Console.WriteLine("*******************");
            Console.WriteLine("Skriv in ditt val:");

            string inmatning = Console.ReadLine();

            switch (inmatning)
            {
                case "1":
                    Console.WriteLine("Mata in tal1");
                    double tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Mata in tal2");
                    double tal2 = double.Parse(Console.ReadLine());
                    double produkten = Multiplicera(tal1, tal2);
                    Console.WriteLine("Produkten är " + produkten);
                    break;
                case "2":
                    Console.WriteLine("Mata in tal1");
                    double tal3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Mata in tal2");
                    double tal4 = double.Parse(Console.ReadLine());
                    double dividera = Dividera(tal3, tal4);
                    Console.WriteLine("Divisionen är " + dividera);
                    break;
                case "3":
                    Console.WriteLine("Mata in text1");
                    string text1 = Console.ReadLine();
                    Console.WriteLine("Mata in text2");
                    string text2 = Console.ReadLine();
                    string längst = Längst(text1, text2);
                    Console.WriteLine(längst);
                    break;
                case "4":
                    return;
                default:
                    return;
            }

            Console.ReadLine();

            double Multiplicera(double tal1, double tal2)
            {
                return tal1 * tal2;
            }

            double Dividera(double tal1, double tal2)
            {
                return tal1 / tal2;
            }

            string Längst(string text1, string text2)
            {
                if(text1.Length >= text2.Length)
                {
                    return text1;
                }
                else
                {
                    return text2;
                }
            }

        }
    }
}

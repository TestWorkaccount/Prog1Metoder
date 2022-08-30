using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Menyval:");
            Console.WriteLine("*******************");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Subtrahera två tal");
            Console.WriteLine("3. Multiplicera två tal");
            Console.WriteLine("4. Avsluta programmet");
            Console.WriteLine("*******************");
            Console.WriteLine("Skriv in ditt val:");

            string inmatning = Console.ReadLine();

            switch(inmatning)
            {
                case "1":
                    Plus();
                    break;
                case "2":
                    Minus();
                    break;
                case "3":
                    Gånger();
                    break;
                case "4":
                    return;
                default:
                    return;
            }

            //Gånger();

            Console.ReadLine();
            
            void Plus()
            {
                Console.WriteLine("Mata in första heltalet");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mata in andra heltalet");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int summa = tal1 + tal2;
                Console.WriteLine("Summan är " + summa);
            }

            void Minus()
            {
                Console.WriteLine("Mata in första heltalet");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mata in andra heltalet");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int summa = tal1 - tal2;
                Console.WriteLine("Subtraktionen är " + summa);
            }

            void Gånger()
            {
                Console.WriteLine("Mata in första heltalet");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mata in andra heltalet");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int summa = tal1 * tal2;
                Console.WriteLine("Produkten är " + summa);
            }
        }
    }
}

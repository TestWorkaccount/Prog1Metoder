using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baklänges("hej");
            Console.WriteLine();
            Baklänges(531);
            Console.WriteLine();
            Baklänges(2.5438);

            Console.ReadLine();
        }

        static void Baklänges(string text)
        {
            for(int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        static void Baklänges(int heltal)
        {
            Baklänges(heltal.ToString());
        }

        static void Baklänges(double flyttal)
        {
            Baklänges(flyttal.ToString());
        }
    }
}

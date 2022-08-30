using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv nåt");
            string inmatning = Console.ReadLine();
            int heltal;
            bool lyckades = int.TryParse(inmatning, out heltal);

            if (lyckades) 
            {
                Console.WriteLine("Det är ett heltal " + heltal);
            }
            else
            {
                Console.WriteLine("Det är inte ett heltal " + heltal);
            }

            Console.ReadLine();

        }
    }
}

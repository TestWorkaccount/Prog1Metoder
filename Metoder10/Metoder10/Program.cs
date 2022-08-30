using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("Hej");
            SkrivVertikalt(531);

            Console.ReadLine();
        }

        static void SkrivVertikalt(string meddelande)
        {
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }
        }

        static void SkrivVertikalt(int vertikaltTal)
        {
            SkrivVertikalt(vertikaltTal.ToString());
        }
    }
}

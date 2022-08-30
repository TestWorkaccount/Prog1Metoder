using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antal = AntalISträng('m', "Välkommen");
            Console.WriteLine(antal);
            int antal2 = AntalISträng('p', "pappa");
            Console.WriteLine(antal2);

            Console.ReadLine();

            int AntalISträng(char tecken, string text)
            {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == tecken)
                    {
                        count++;
                    }
                }
                //int count = text.Count(x => x == tecken);

                return count;
            }
        }
    }
}

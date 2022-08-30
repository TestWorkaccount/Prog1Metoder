using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("hej", 0);
            SkrivVertikalt("hejsan");
            SkrivVertikalt("hejsan", 5);
            SkrivVertikalt("extra", 1, 5); //tillägg på övning 13

            Console.ReadLine();
        }


        static void SkrivVertikalt(string text, int antalTommaRader, int stegÅtHöger)
        {
            for (int i = 0; i < text.Length; i++)
            {   
                for(int j = 0; j < stegÅtHöger; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(text[i]);
                if (i < text.Length-1) 
                {
                    for (int j = 0; j < antalTommaRader; j++)
                    {
                        Console.WriteLine();
                    }
                }

            }
        }

        static void SkrivVertikalt(string text, int antalTommaRader)
        {
            SkrivVertikalt(text, antalTommaRader, 0);
        }

        static void SkrivVertikalt(string text)
        {
            SkrivVertikalt(text, 0);
        }
    }
}

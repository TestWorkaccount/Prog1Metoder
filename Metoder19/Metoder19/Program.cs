using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal = 15;
            Console.WriteLine($"{tal}");

            Vartannat("Hej på dig där!");



            Console.ReadLine();

            void Vartannat(string text)
            {
                string[] strArray = text.Split(new char[] { ' ' });
                for(int i = 0; i < strArray.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        string output = strArray[i].ToUpper();
                        Console.Write(output);
                    }
                    else
                    {
                        string output = strArray[i].ToLower();
                        Console.Write(output);
                    }
                    if(i < strArray.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}

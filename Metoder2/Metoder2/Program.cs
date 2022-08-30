using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SkrivBaklänges("hej");
            SkrivBaklänges("hejsan");
            SkrivBaklänges("hej då då");

            Skrivbak2("hej");
            Console.WriteLine();
            Skrivbak2("hejsan");
            Console.WriteLine();
            Skrivbak2("hej då då");


            //string med = Skriv2("hej");
            //Console.WriteLine(med + " Skriv2");

            Console.ReadLine();


            //hittade den här metoden online
            //https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string
            void SkrivBaklänges(string meddelande)
            {
                char[] bokstavsArray = meddelande.ToCharArray();
                Array.Reverse(bokstavsArray);
                Console.WriteLine(new string(bokstavsArray));
            }

            void Skrivbak2(string meddelande)
            {
                for(int i = meddelande.Length -1; i >= 0; i--)
                {
                    Console.Write(meddelande[i]);
                }
            }



            //string Skriv2(string meddelande)
            //{
            //    char[] bokstavsArray = meddelande.ToCharArray();
            //    Array.Reverse(bokstavsArray);
            //    return new string(bokstavsArray);
            //}

        }


    }
}

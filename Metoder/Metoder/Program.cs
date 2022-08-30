using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkrivTalIKvadrat(5);
            SkrivTalIKvadrat(17);
            SkrivTalIKvadrat(100);

            //SkrivTalIKvadratTvå(5);
            //SkrivTalIKvadratTvå(17);
            //SkrivTalIKvadratTvå(100);

            //Program p = new Program();
            //p.SkrivTalIKvadratTre(5);

            Console.ReadLine();

            void SkrivTalIKvadrat(int tal)
            {
                //double resultat = Math.Pow(tal, 2);
                int iKvadrat = tal * tal;
                Console.WriteLine(iKvadrat);
            }
        }
        static void SkrivTalIKvadratTvå(int tal)
        {
            //double resultat = Math.Pow(tal, 2);
            int iKvadrat = tal * tal;
            Console.WriteLine(iKvadrat);
        }

        void SkrivTalIKvadratTre(int tal)
        {
            //double resultat = Math.Pow(tal, 2);
            int iKvadrat = tal * tal;
            Console.WriteLine(iKvadrat);
        }

    }
}

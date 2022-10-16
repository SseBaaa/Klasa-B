using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");

            string s = Console.ReadLine();

            KlasaB x = new KlasaB();
            if (s.Length > 2)
            {
                s = x.BezPrvogIZadnjeg(s);
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}

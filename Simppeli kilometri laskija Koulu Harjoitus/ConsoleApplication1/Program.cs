using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int min = 0;
            int km = 0;
            int aika = 0;



            Console.WriteLine("Montako minuuttia menee kilometrin ajamiseen?");
            min = int.Parse(Console.ReadLine());


            Console.WriteLine("Montako kilometriä ajat?");
            km = int.Parse(Console.ReadLine());

            aika = km * min;

            while (aika >= 60)
            {
                    h = h + 1;
                    aika = aika - 60;
                    min = aika;
            }
               Console.WriteLine(h + " Tuntia " + min + " minuuttia ");


            Console.ReadKey();
        }
    }
}

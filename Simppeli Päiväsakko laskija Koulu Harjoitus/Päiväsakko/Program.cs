using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päiväsakko
{
    class Program
    {
        static void Main(string[] args)
        {

            //Teemu Karhunen
            decimal nettotulo = 0m;
            int lapset = 0;
            decimal paivasakko = 0m;

            Console.WriteLine("Mikä on nettotulosi? ");
            nettotulo = int.Parse(Console.ReadLine());


            Console.WriteLine("Laten määrä ");
            lapset = int.Parse(Console.ReadLine());

            paivasakko = (nettotulo - 255) / 60 - lapset * 3;

            Console.WriteLine("Päiväsakkosi on " + (int)paivasakko + " euroa");

            Console.ReadKey();

        }
    }
}

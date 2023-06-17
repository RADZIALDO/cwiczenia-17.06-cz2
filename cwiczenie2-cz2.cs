using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie2_cz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            Random random = new Random();

            int licznikLosowan = 0;
            int iloscLiczbyDoWylosowania = n;

            for (int iloscLiczbWylosowanych = 0; iloscLiczbWylosowanych < iloscLiczbyDoWylosowania; iloscLiczbWylosowanych++)
            {
                int wylosowanaLiczba;
                wylosowanaLiczba = random.Next(-4, 5);
                wylosowanaLiczba *= 2;

                licznikLosowan++;
                

                Console.Write(wylosowanaLiczba);

                if (iloscLiczbWylosowanych < iloscLiczbyDoWylosowania - 1)
                    Console.Write(", ");
            }

            Console.WriteLine("\nLicznik liczb wylosowanych: " + licznikLosowan);

            Console.ReadKey();
        }
    }
}


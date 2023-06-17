using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie2
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
                do
                {
                    wylosowanaLiczba = random.Next(-8, 9);
                    licznikLosowan++;
                }while(wylosowanaLiczba%2 != 0);

                Console.Write(wylosowanaLiczba);

                if (iloscLiczbWylosowanych < iloscLiczbyDoWylosowania - 1)
                    Console.Write(", ");
            }

            Console.WriteLine("\nLicznik liczb wylosowanych: " + licznikLosowan);

            Console.ReadKey();
        }
    }
}

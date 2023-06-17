using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę liczb pierwszych do wypisania: ");
            int n = wczytaj();

            int liczba = 2;

            Console.WriteLine("Wypisane liczby pierwsze: ");
            int liczbaLiczbPierwszych = 0;

            while(liczbaLiczbPierwszych < n) 
            {
                if(CzyLiczbaPierwsza(liczba))
                {
                    Console.WriteLine(liczba);
                    liczbaLiczbPierwszych++;
                }
                liczba++;
            }

            Console.ReadKey();
        }
        static int wczytaj()
        {
            int wynik;
            while (!int.TryParse(Console.ReadLine(), out wynik)) ;
            return wynik;
        }
        static bool CzyLiczbaPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

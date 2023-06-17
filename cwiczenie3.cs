using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokosc trójkąta: ");
            int wysokosc = wczytaj();

            RysujTrojkat(wysokosc);

            Console.ReadKey();
        }
        static int wczytaj()
        {
            int wynik;
            while (!int.TryParse(Console.ReadLine(), out wynik)) ;
            return wynik;
        }
        static void RysujTrojkat(int wysokosc)
        {
            int szerokosc = wysokosc * 2 - 1;

            for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
            {
                int liczbaPlusow = wiersz * 2 - 1;
                int liczbaSpacji = (szerokosc - liczbaPlusow) / 2;

                for (int i = 0; i < liczbaSpacji; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < liczbaPlusow; i++)
                {
                    Console.Write("+");
                }

                Console.WriteLine();
            }
        }
    }
}

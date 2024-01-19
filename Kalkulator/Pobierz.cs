using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pobieranie
{
    internal class Pobierz
    {
        // pobiera dowolną liczbę całkowitą
        public static int Liczbe()
        {
            int liczba;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    return liczba;

                }
                else
                {
                    Console.WriteLine("Błędna wartość. Podaj liczbe całkowita");
                }
            } while (true);
        }

        // pobiera liczbę całkowitą z przediału od a do b
        public static int Liczbe(int a, int b) 
        {
            Console.WriteLine("podaj liczbe całkowitą z przediału od " + a + " do " + b);
            int liczba;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    if (liczba >= a && liczba <= b)
                    {
                        return liczba;
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość. podaj liczbe całkowitą z przediału od " + a + " do " + b);
                    }
                }
                else
                {
                    Console.WriteLine("Błędna wartość. podaj liczbe całkowitą z przediału od " + a + " do " + b);
                }
            } while (true);
        }
    }
}

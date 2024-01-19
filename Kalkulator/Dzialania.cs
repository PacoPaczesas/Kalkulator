using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pobieranie;

namespace DzialaniaPodstawowe
{
    internal class Dzialania
    {

        public static void Dodawanie()
        {
            Console.WriteLine("DODAWANIE");
            Console.Write("podaj pierwszą wartość: ");
            int a = Pobierz.Liczbe();
            Console.Write("podaj drugą wartość: ");
            int b = Pobierz.Liczbe();
            int suma = a + b;
            Console.Write("suma " + a + " plus " + b + " wynosi: " + suma);
        }
        public static void Odejmowanie()
        {
            Console.WriteLine("ODEJMOWANIE");
            Console.Write("podaj pierwszą wartość, od której będziemy odejmować: ");
            int a = Pobierz.Liczbe();
            Console.Write("podaj drugą wartość, którą będziemy odejmować: ");
            int b = Pobierz.Liczbe();
            int suma = a - b;
            Console.Write("różnica " + a + " minus " + b + " wynosi: " + suma);
        }

        public static void Mnozenie()
        {
            Console.WriteLine("MNOŻENIE");
            Console.Write("podaj pierwszą wartość: ");
            int a = Pobierz.Liczbe();
            Console.Write("podaj drugą wartość: ");
            int b = Pobierz.Liczbe();
            int suma = a * b;
            Console.Write("iloraz " + a + " razy " + b + " wynosi: " + suma);
        }

        public static void Dzielenie()
        {
            Console.WriteLine("DZIELENIE");
            Console.Write("podaj pierwszą wartość, która będzie dzielona: ");
            int a = Pobierz.Liczbe();
            Console.Write("podaj drugą wartość, przez którą dzielimy: ");
            int b = Pobierz.Liczbe();
            double suma = ((double) a / b);
            Console.Write("iloczyn " + a + " porzielić przez " + b + " wynosi: " + suma);
        }

        public static void PodnoszenieDoPotegi()
        {
            Console.WriteLine("PODNOSZENIE DO POTEGI");
            Console.Write("Wprowadź podstawę potęgi: ");
            int a = Pobierz.Liczbe();
            Console.Write("Wprowadź wykładnik: ");
            int b = Pobierz.Liczbe();

            if (b == 0)
            {
                Console.WriteLine("0");
            }
            else if (b == 1)
            {
                Console.WriteLine(a);
            }
            else
            {
                int suma = a;
                for (int i = 1; i < b; i++)
                {
                    suma = suma * a;
                    Console.WriteLine(a + " do potęgi " + b + " wynosi: " + suma);
                }
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Pobieranie;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            double suma = ((double)a / b);
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
        public static void FunkcjaKwadratowa()
        {
            Console.WriteLine("WYLICZENIE DELTY I MIEJSCE ZEROWYCH FUNKCJI KWADRATOWEJ");
            Console.WriteLine("Funkcja kwadratowa ma postać f(x) = ax^2 + bx + c");
            Console.Write("Wprowadź wartość a: ");
            int a = Pobierz.Liczbe();
            Console.Write("Wprowadź wartość b: ");
            int b = Pobierz.Liczbe();
            Console.Write("Wprowadź wartość c: ");
            int c = Pobierz.Liczbe();

            int delta = (int)Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("delta wynosi: " + delta);

            if (delta < 0)
            {
                Console.WriteLine("Brak miejsc zerowych");
            }
            else if (delta == 0)
            {
                int x1 = -b / 2 * a;
                Console.WriteLine("jedno miejsce zerowe: " + x1);
            }
            else
            {
                double x1 = (-b - (double)Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + (double)Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("dwa miejsca zerowe. x1: " + x1 + " x2: " + x2);
            }
        }
        public static void PoleTrojkataPoDlugosciBokow()
        {
            Console.WriteLine("WYLICZENIE POLA TROJKĄTA PO DŁUGOŚCI JEGO BOKÓW");

            bool sprawdzeniePoprawności = false;
            int a = 0;
            int b = 0;
            int c = 0;

            while (!sprawdzeniePoprawności)
            {
                Console.Write("Wprowadź długość pierwszego boku: ");
                a = Pobierz.LiczbeWiekszaOd(0);
                Console.Write("Wprowadź długość drugiego boku: ");
                b = Pobierz.LiczbeWiekszaOd(0);
                Console.Write("Wprowadź długość trzeciego boku: ");
                c = Pobierz.LiczbeWiekszaOd(0);

                if (((a + b) > c) && ((b + c) > a) && ((c + a) > b))
                {
                    sprawdzeniePoprawności = true;
                }
                else
                {
                    Console.WriteLine("Trójkąt o takich bokach nie istnieje. Poad prawidłowe wartości.");
                }
            }

            double polowaObwoduTrojkata = (a + b + c) / 2;
            double pole;
            pole = Math.Sqrt(polowaObwoduTrojkata) * (polowaObwoduTrojkata - a) * (polowaObwoduTrojkata - b) * (polowaObwoduTrojkata - c);
            Console.WriteLine("Pole trójkąta o bokach a=" + a + "; b=" + b + "; c=" + c + " wynosi: " + pole);
        }

        public static void OrzekanieOZnakuLiczby()
        {
            Console.WriteLine("ORZEKANIE O ZNAKU LICZBY");
            Console.Write("Wprowadć wartość: ");
            int a = Pobierz.Liczbe();
            string znak;
            znak = (a > 0) ? "Dodatnia" : (a < 0) ? "Ujemna" : "Zero";
            Console.WriteLine("Znak liczby: " + znak);
        }
        public static void SprawdzenieParzystoscLiczby()
        {
            Console.WriteLine("SPRAWDZANIE PARZYSTOSCI LICZBY");
            Console.WriteLine("Wprowadź wartość: ");
            int a = Pobierz.Liczbe();
            string czyParzysta;
            czyParzysta = ((a % 2) == 0) ? "Parzysta" : "Nieparzysta";
            Console.WriteLine(czyParzysta);
        }
        public static void ZnajdzDzielniki()
        {
            Console.WriteLine("ZNAJDYWANIE DZIELNIKÓW");
            Console.Write("Wprowadź wartość: ");
            int a = Pobierz.Liczbe();
            int reszta;
            int iloscDzielnikow = 0;

            Console.Write("Dzielniki liczby " + a + " to:");

            for (int i = 1; i <= a; i++)
            {
                reszta = a % i;
                if (reszta == 0)
                {
                    Console.Write(" " + i);
                    iloscDzielnikow++;
                }
            }
            Console.Write(". Liczba " + a + " ma " + iloscDzielnikow + " dzielników");
        }
        public static void ObliczSilnie()
        {
            Console.WriteLine("OBLICZANIE SILNI");
            Console.Write("Wprowadź wartość: ");
            int a = Pobierz.LiczbeWiekszaOd(0);
            int suma = 1;

            for (int i = 1; i <= a; i++)
            {
                suma = suma * i;
            }

            Console.WriteLine("Silnia liczby " + a + " wynosi: " + suma);
        }
        public static void NWD()
        {
            Console.WriteLine("Program obliczający NWD dowolną metodą Euklidesa.");
            Console.Write("Podaj pierwszą liczbę: ");
            int a = Math.Abs(Pobierz.Liczbe());
            Console.Write("Podaj drugą liczbę: ");
            int b = Math.Abs(Pobierz.Liczbe());
            int result = 0;
            while (b > 0)
            {
                result = b;
                b = a % b;
                a = result;
            }
            Console.WriteLine("NWD podanych liczb to: " + a);
        }
        public static void LiczbaBinarnaNaDecymalna()
        {
            Console.WriteLine("Zamiana liczby binarnej na decymalną");
            List<char> listBin = new List<char>();
            bool error = false;

            do
            {
                Console.Write("podaj liczbę binarną składającą się z zer i jedynej: ");
                int binInt = Pobierz.LiczbeWiekszaOd(0);
                string binStrng = binInt.ToString();
                Console.WriteLine(binStrng);

                for (int i = 0; i < binStrng.Length; i++)
                {
                    char c = binStrng[i];
                    listBin.Add(c);
                }
                int listCount = listBin.Count;

                //ponizej jest do zmiany
                foreach (char c in listBin)
                {
                    if (c == '0' || c == '1')
                    {

                    }
                    else
                    {
                        Console.WriteLine("Błędne dane");
                        error = true;
                        break;
                    }
                }
            } while (error);

            int decNumber = 0;
            int row = 0;
            int zeroOrOne;
            for (int i = listBin.Count - 1; i >= 0; i--)
            {
                //zeroOrOne = (int)list01.ElementAt(i);
                zeroOrOne = (int)Char.GetNumericValue(listBin.ElementAt(i));
                decNumber += zeroOrOne * (int)Math.Pow(2, row);
                row++;
            }

            Console.WriteLine("Liczba w systemie dziesietnym: " + decNumber);
        }

    }
}

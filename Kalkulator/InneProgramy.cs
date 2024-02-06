using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pobieranie;



namespace InneProgramy
{
    internal class Programy
    {

        public static void RysujKwadrat()
        {
            Console.WriteLine("Program rysujący kwadrat złożony z gwiazdek o boku podanym przez użytkownika.");
            int a = Pobierz.LiczbeWiekszaOd(0);
            Console.WriteLine(" ");

            for (int i = 0; i < a; i++)
            {
                if ((i == 0) || (i == (a-1)))
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
                else
                {
                    for(int j = 0;j < a; j++)
                    {
                        if((j == 0) || (j == (a-1)))
                        {
                            Console.Write("*");
                        }else { 
                            Console.Write(" "); 
                        }
                    }
                    Console.WriteLine(" ");
                }

            }
        }

        public static void LosujLiczbeZPrzednialu()
        {
            Console.WriteLine("13. Program losujący liczbę losową, liczbę z przedziału od 0 do 10 i z przedziału od „p” do „k”");
            Random random = new Random();
            int a = random.Next(0, 10);
            Console.Write("Podaj liczbę od jakiego rozpocząć ma się przedział losowanych liczb: ");
            int minNum = Pobierz.Liczbe();
            Console.Write("Podaj liczbe na jakiej konczyc ma się przedział losowanych liczb");
            int maxNum = Pobierz.LiczbeWiekszaOd(minNum);
            int b = random.Next(minNum, maxNum);
            Console.WriteLine("Wylosowana liczba z zakresu 0 - 10: " + a);
            Console.WriteLine("Wylosowana liczba z zakresu " + minNum + " - " + maxNum + ": " + b);
        }

        public static void HeadsOrTails()
        {
            Console.WriteLine("Program losujący i rzucający 1000 razy monetę z wyznaczeniem ilości orłów i reszek");
            int heads = 0;
            int tails = 0;
            int rand;
            Random random = new Random();

            for (int i = 0; i < 1000; i++) {
                //rand = random.Next(1, 2); - zawsze wypada 1. Dlaczego?
                rand = random.Next(2);
                //rand == 1 ? heads++ : tails++;

                if (rand == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("Orzeł wypadł " + heads + " razy");
            Console.WriteLine("Reszka wypadła " + tails + " razy");
        }

        public static void RollD6()
        {
            Console.WriteLine("Program rzucający kostką do czasu wyrzucenia szóstki z wyznaczeniem ilości rzutów");
            int rolls = 0;
            int result = 0;
            Random rand = new Random();
            do
            {
                result = rand.Next(1, 7);
                rolls++;
                Console.WriteLine(result);

            } while (result != 6);
            Console.WriteLine("Wyrzucono 6 za " + rolls + " razem");

        }


        public static void PESEL()
        {
            Console.WriteLine("Program sprawdza poprawność pesel, wyświetla płeć oraz datę urodzenia");

            string stringPESEL;
            int[] numbersInPESEL = new int[11];
            char c;
            int number;
            bool onlyNumbers = true;
            
            do
            {
                if (onlyNumbers == false)
                {
                    Console.WriteLine("Wprowadzono błędny PESEL. Pamiętaj, że PESEL składa się wyłączenie ze znaków od 0 - 9 i jest to ciąg 11 znaków");
                } else
                {
                    Console.WriteLine("Wprowadź nr PESEL: ");
                }
                stringPESEL = Console.ReadLine();
                onlyNumbers = true;
                foreach (char ch in stringPESEL)
                {
                    if (!char.IsDigit(ch))
                    {
                        onlyNumbers = false;
                        break;
                    }
                }

                if (stringPESEL.Length != 11)
                {
                    onlyNumbers = false;
                }
            } while (stringPESEL.Length != 11 || !onlyNumbers);

            for (int i = 0;i < numbersInPESEL.Length;i++)
            {
                c = stringPESEL[i];
                number = (int)(c - '0');
                numbersInPESEL[i] = number;
            }

            Console.WriteLine(numbersInPESEL[1]);
            Console.WriteLine(numbersInPESEL[1]);
            Console.WriteLine(numbersInPESEL[2]);
            Console.WriteLine(numbersInPESEL[3]);

            Console.WriteLine("Data urodzenia to dzień: " + numbersInPESEL[4] + numbersInPESEL[5] + ", miesciąc: " + numbersInPESEL[2] + numbersInPESEL[3] + ", rok: 19" + numbersInPESEL[0] + numbersInPESEL[1]);










        }


    }
}

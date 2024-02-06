using DzialaniaPodstawowe;
using Pobieranie;
using InneProgramy;


Console.WriteLine("Witaj w aplikacji kalkulator.");
bool wyjdz = false;

while (!wyjdz)
{
    Console.WriteLine(" ");
    Console.WriteLine("wybierz działanie, jakie chcesz wykonać");
    Console.WriteLine("1. Dodawanie");
    Console.WriteLine("2. Odejmowanie");
    Console.WriteLine("3. Mnozenie");
    Console.WriteLine("4. Dzielenie");
    Console.WriteLine("5. Podnoszeie do potegi");
    Console.WriteLine("6. Funkcja kwadratowa - wyliczenie delty i miejsc zerowych");
    Console.WriteLine("7. Oblicz pole trojkata na podstawie długości jego boków (Wzór Herona)");
    Console.WriteLine("8. Orzekanie o znaku liczby");
    Console.WriteLine("9. Sprawdzenie parzystości liczby");
    Console.WriteLine("10. Wyszukaj dzielniki liczby");
    Console.WriteLine("11. Oblicz silnie");
    Console.WriteLine("12. Program obliczający NWD dowolną metodą Euklidesa.");
    Console.WriteLine("INNE PROGRAMY");
    Console.WriteLine("12. Program rysujący kwadrat złożony z gwiazdek o boku podanym przez użytkownika");
    Console.WriteLine("13. Program losujący liczbę losową, liczbę z przedziału od 0 do 10 i z przedziału od „p” do „k”");
    Console.WriteLine("14. Program losujący i rzucający 1000 razy monetę z wyznaczeniem ilości orłów i reszek");
    Console.WriteLine("15. Program rzucający kostką do czasu wyrzucenia szóstki z wyznaczeniem ilości rzutów");
    Console.WriteLine("16. Program obliczający NWD dowolną metodą Euklidesa.");
    Console.WriteLine("17. Zamiana liczby binarnej na decymalną");
    Console.WriteLine("18. Zaokrąglanie liczby");
    Console.WriteLine("99. Wyjdz");

    // 16
    int wybor = Pobierz.Liczbe(1, 99);

    switch (wybor)
    {
        case 1:
            Dzialania.Dodawanie();
            break;
        case 2:
            Dzialania.Odejmowanie();
            break;
        case 3:
            Dzialania.Mnozenie();
            break;
        case 4:
            Dzialania.Dzielenie();
            break;
        case 5:
            Dzialania.PodnoszenieDoPotegi();
            break;
        case 6:
            Dzialania.FunkcjaKwadratowa();
            break;
        case 7:
            Dzialania.PoleTrojkataPoDlugosciBokow();
            break;
        case 8:
            Dzialania.OrzekanieOZnakuLiczby();
            break;
        case 9:
            Dzialania.SprawdzenieParzystoscLiczby();
            break;
        case 10:
            Dzialania.ZnajdzDzielniki();
            break;
        case 11:
            Dzialania.ObliczSilnie();
            break;
        case 12:
            Programy.RysujKwadrat();
            break;
        case 13:
            Programy.LosujLiczbeZPrzednialu();
            break;
        case 14:
            Programy.HeadsOrTails();
            break;
        case 15:
            Programy.RollD6();
            break;
        case 16:
            Dzialania.NWD();
            break;
        case 17:
            Dzialania.LiczbaBinarnaNaDecymalna();
            break;
        case 18:
            Dzialania.RoundNumber();
            break;
        case 99:
            wyjdz = true;
            break;
        default:
            Console.WriteLine("Błąd");
            break;
    }

    Console.ReadKey();
}

//Console.WriteLine(Zwracaj(a, b));

/*int Zwracaj(int a, int b)
=> a + b;*/
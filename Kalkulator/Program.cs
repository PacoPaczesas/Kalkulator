using DzialaniaPodstawowe;
using Pobieranie;


Console.WriteLine("Witaj w aplikacji kalkulator.");
Console.WriteLine("wybierz działanie, jakie chcesz wykonać");

Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnozenie");
Console.WriteLine("4. Dzielenie");
Console.WriteLine("5. Podnoszeie do potegi");
Console.WriteLine("6. Zamknij");
int wybor = Pobierz.Liczbe(1, 6);



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
        Console.WriteLine("zamknij");
        break;
    default:
        Console.WriteLine("Błąd");
        break;
}


Console.ReadKey();

//Console.WriteLine(Zwracaj(a, b));

/*int Zwracaj(int a, int b)
=> a + b;*/
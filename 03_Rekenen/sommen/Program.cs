namespace sommen;

class Program
{
    static void Main(string[] args)
    {
        //+ - / *
        Console.WriteLine("Hello, World!");

        int keersom = 5 * 6;
        Console.WriteLine("wat is het resultaat van vijf keer zes?");
        Console.WriteLine($"{keersom}");

        int plussom = 8 + 7;
        Console.WriteLine("wat krijg je als je acht plus zeven optelt?");
        Console.WriteLine($"{plussom}");

        int minsom = 20 - 9;
        Console.WriteLine("wat is twintig min negen?");
        Console.WriteLine($"{minsom}");

        int deelsom = 24 / 3;
        Console.WriteLine("hoeveel is vierentwintig gedeeld door drie?");
        Console.WriteLine($"{deelsom}");

        int rekensom = 10 + 5 * 2;
        Console.WriteLine("wat is het antwoord op tien plus vijf keer twee?");
        Console.WriteLine($"{rekensom}");
    }
}

namespace of;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("maak een keuze (0, 1, 2, 3, 4)");

        int keuze = int.Parse(Console.ReadLine());

        if (keuze == 1 || keuze == 2)
        {
            Console.WriteLine("YUM YUM");
        }

        else if (keuze == 3 || keuze == 4)
        {
            Console.WriteLine("CHOMP");
        }

        else
        {
            Console.WriteLine("Bleh!");
        }

    }
}

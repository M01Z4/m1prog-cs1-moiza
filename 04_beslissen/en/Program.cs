namespace en;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("doorNeedkey? y/n");
        bool doorNeedkey = Console.ReadLine() == "y";   
        
        Console.WriteLine("player haskey? (y/n)");
        bool hasKey = Console.ReadLine() == "y";

        if (doorNeedkey && hasKey)
        {
            Console.WriteLine("je staat voor een deur");
            Console.WriteLine("de deur zit op slot");
            Console.WriteLine("je gebruikt de sleutel om de deur te openen");
        }
        else if (doorNeedkey)
        {
            Console.WriteLine("je staat voor een deur");
            Console.WriteLine("de deur zit op slot");
        }
        else if (hasKey)
        {

            Console.WriteLine("je staat voor een deur");
        }
        else
        {
            Console.WriteLine("je staat voor een deur");
        }





    }
}

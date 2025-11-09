namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("heb je de sleutel gevonden? (Y/N)");
        bool sleutelKwijt = Console.ReadLine() == "N";


        if (sleutelKwijt)
        {
            Console.WriteLine("je bent je sleutel kwijt!");
            Console.WriteLine("de deur blijft gesloten");
        
        }

        else
        {
        
        
            Console.WriteLine("je hebt de sleutel");
            Console.WriteLine("de deur gaat open en je kan naar binnen");
        
        }
        
    }
}

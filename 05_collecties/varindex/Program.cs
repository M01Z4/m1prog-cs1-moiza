namespace varindex;

class Program
{
    static void Main(string[] args)
    {
         string[] karakters = { "mario", "sonic", "spyro" };

            
            for (int i = 0; i < karakters.Length; i++)
            {
                Console.WriteLine($"{i}: {karakters[i]}");
            }

            
            Console.WriteLine("maak een keuze");
            string keuze = Console.ReadLine();

            
            int gekozenIndex = int.Parse(keuze);

           
            Console.WriteLine($"je koos: {gekozenIndex}");

            
            Console.WriteLine($"je koos voor: {karakters[gekozenIndex]}");
    }
}

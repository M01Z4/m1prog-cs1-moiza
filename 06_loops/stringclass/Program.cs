namespace stringclass;

class Program
{
    static void Main(string[] args)
    {

        string[] geenCaps = { "global", "variable", "class" };


        for (int i = 0; i < geenCaps.Length; i++)
        {
            string woord = geenCaps[i];

            Console.WriteLine(woord);
            Console.WriteLine($"is een string die {woord.Length} lang is");
            Console.WriteLine(woord.ToUpper());
        }
    }
}
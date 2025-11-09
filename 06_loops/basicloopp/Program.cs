namespace basicloopp;

class Program
{
    static void Main(string[] args)
    {

        int[] nummers = { 42, 60, 89 };


        for (int i = 0; i < nummers.Length; i++)
        {

            int temp = nummers[i];


            Console.WriteLine($"{i}: {temp}");
        }
    }
}
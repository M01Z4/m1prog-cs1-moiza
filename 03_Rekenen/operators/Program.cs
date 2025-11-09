using System.IO.Pipes;

namespace operators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int plus = 9;

        plus = plus + 1;
        Console.WriteLine("plus start op 9");
        Console.WriteLine($"plus is nu {plus}");

        plus--;
        Console.WriteLine($"plus is nu {plus}");
        plus--;
        Console.WriteLine($"plus is nu {plus}");
    }
}

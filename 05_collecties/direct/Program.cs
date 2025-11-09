namespace direct;

class Program
{
    static void Main(string[] args)
    {
        double[] percentages = new double[] { 0.5, 1.2, 3.8, 4.6, 9.9 };


        double temp = percentages[3];
        Console.WriteLine(temp);


        temp = percentages[1];
        Console.WriteLine(temp);


        temp = percentages[2];
        Console.WriteLine(temp);

        Console.WriteLine();

        double[] cijfers = new double[] { 0.8, 8.9, 8.23, 7.8, 4.2, 7.6 };


        Console.WriteLine($"eerste item in de array op index 0 heeft de waarde {cijfers[0]}");
        Console.WriteLine($"tweede item in de array op index 1 heeft de waarde {cijfers[1]}");
        Console.WriteLine($"derde item in de array op index 2 heeft de waarde {cijfers[2]}");
        Console.WriteLine($"vierde item in de array op index 3 heeft de waarde {cijfers[3]}");
        Console.WriteLine($"vijfde item in de array op index 4 heeft de waarde {cijfers[4]}");
        Console.WriteLine($"zesde item in de array op index 5 heeft de waarde {cijfers[5]}");
    }
}

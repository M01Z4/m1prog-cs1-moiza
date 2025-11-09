namespace forfunc;

class Program
{
    static void Main(string[] args)
    {

        double[] basis = { 2, 5, 78, 98 };


        for (int i = 0; i < basis.Length; i++)
        {

            double getal = basis[i];


            double resultaat = Math.Pow(getal, 2);


            Console.WriteLine($"{getal} keer zichzelf {resultaat}");
        }
    }
}
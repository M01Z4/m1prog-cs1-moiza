namespace bruto;

class Program
{
    static void Main(string[] args)
    {
         double[] brutoSalarissen = new double[]
            {
                13450.80,
                85698.90,
                39598.23
            };

           
            double[] nettoSalarissen = new double[3];

            
            double schijf1 = 0.3582;  
            double schijf2 = 0.3748;  
            double schijf3 = 0.4950; 

           
            nettoSalarissen[0] = brutoSalarissen[0] * (1 - schijf1);
            nettoSalarissen[1] = brutoSalarissen[1] * (1 - schijf3);
            nettoSalarissen[2] = brutoSalarissen[2] * (1 - schijf2);

           
            Console.WriteLine($"persoon 1 houdt {nettoSalarissen[0]:F2} netto over van {brutoSalarissen[0]:F2} bruto");
            Console.WriteLine($"persoon 2 houdt {nettoSalarissen[1]:F2} netto over van {brutoSalarissen[1]:F2} bruto");
            Console.WriteLine($"persoon 3 houdt {nettoSalarissen[2]:F2} netto over van {brutoSalarissen[2]:F2} bruto");
    }
}

namespace _1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double[] taxTiers = { 0, 0.08, 0.18, 0.28 };

            if (input > 4500)
            {
                double taxTier3 = (input - 4500) * taxTiers[3];
                double taxtier2 = 1500 * taxTiers[2];
                double taxtier1 = 1000 * taxTiers[1];
                Console.WriteLine($"R$ {(taxTier3 + taxtier2 + taxtier1):F2}");
            }
            else if (input <= 4500 && input > 3000)
            {
                double taxtier2 = (input - 3000) * taxTiers[2];
                double taxtier1 = ((input - 2000) - (input - 3000)) * taxTiers[1];
                Console.WriteLine($"R$ {(taxtier2 + taxtier1):F2}");
            }
            else if (input <= 3000 && input > 2000)
            {
                double taxtier1 = (input - 2000) * taxTiers[1];
                Console.WriteLine($"R$ {taxtier1:F2}");
            }
            else
            {
                Console.WriteLine("Isento");
            }
        }
    }
}
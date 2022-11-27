namespace _1036
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double C = double.Parse(input[2]);

            double sqrtBhaskara = Math.Sqrt(Math.Pow(B, 2) - 4 * A * C);

            if (2 * A == 0 || (Math.Pow(B, 2) - 4 * A * C) < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double bhaskarar1 = (-B + sqrtBhaskara) / (2 * A);
                double bhaskarar2 = (-B - sqrtBhaskara) / (2 * A);
                Console.WriteLine($"R1 = {bhaskarar1:F5}");
                Console.WriteLine($"R2 = {bhaskarar2:F5}");
            }
        }
    }
}
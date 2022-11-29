namespace _1060
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            double E = double.Parse(Console.ReadLine());
            double F = double.Parse(Console.ReadLine());

            double[] input = { A, B, C, D, E, F };
            int count = 0;

            foreach (var number in input)
            {
                if (number > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count} valores positivos");
        }
    }
}
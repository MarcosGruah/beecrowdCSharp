namespace _1098
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double I = 0;
            double J = 1;

            while (I <= 2)
            {
                Console.WriteLine($"I={(I).ToString("0.##")} J={(J.ToString("0.##"))}");
                Console.WriteLine($"I={(I).ToString("0.##")} J={(J + 1).ToString("0.##")}");
                Console.WriteLine($"I={(I).ToString("0.##")} J={(J + 2).ToString("0.##")}");

                I += 0.2;
                J += 0.2;
            }
        }
    }
}
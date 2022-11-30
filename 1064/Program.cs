namespace _1064
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<double> input = new List<double>();
            int positiveCount = 0;
            double average = 0;

            for (int i = 0; i < 6; i++)
            {
                input.Add(double.Parse(Console.ReadLine()));
            }

            foreach (var n in input)
            {
                if (n > 0)
                {
                    positiveCount++;
                    average += n;
                }
            }

            Console.WriteLine($"{positiveCount} valores positivos");
            Console.WriteLine($"{(average / positiveCount):F1}");
        }
    }
}
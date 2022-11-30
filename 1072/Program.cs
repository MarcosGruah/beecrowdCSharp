namespace _1072
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            int inInterval = 0;
            int outInterval = 0;

            for (int i = 0; i < count; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var n in input)
            {
                if (n >= 10 && n <= 20)
                {
                    inInterval++;
                }
                else
                {
                    outInterval++;
                }
            }

            Console.WriteLine($"{inInterval} in");
            Console.WriteLine($"{outInterval} out");
        }
    }
}
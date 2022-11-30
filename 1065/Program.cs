namespace _1065
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> input = new List<int>();
            int evenCount = 0;

            for (int i = 0; i < 5; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var n in input)
            {
                if (n % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"{evenCount} valores pares");
        }
    }
}
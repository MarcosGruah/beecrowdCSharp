namespace _1066
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> input = new List<int>();
            int evenCount = 0;
            int oddCount = 0;
            int positiveCount = 0;
            int negativeCount = 0;

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
                else
                {
                    oddCount++;
                }

                if (n > 0)
                {
                    positiveCount++;
                }
                else if (n < 0)

                {
                    negativeCount++;
                }
            }

            Console.WriteLine($"{evenCount} valor(es) par(es)");
            Console.WriteLine($"{oddCount} valor(es) impar(es)");
            Console.WriteLine($"{positiveCount} valor(es) positivo(s)");
            Console.WriteLine($"{negativeCount} valor(es) negativo(s)");
        }
    }
}
namespace _1073
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                }
            }
        }
    }
}
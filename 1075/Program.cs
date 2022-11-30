namespace _1075
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10001; i++)
            {
                if (i % input == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
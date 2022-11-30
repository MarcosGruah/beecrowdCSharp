namespace _1097
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int I = 1;
            int J = 7;

            while (I <= 9)
            {
                Console.WriteLine($"I={I} J={J}");
                J--;
                Console.WriteLine($"I={I} J={J}");
                J--;
                Console.WriteLine($"I={I} J={J}");
                J += 4;
                I += 2;
            }
        }
    }
}
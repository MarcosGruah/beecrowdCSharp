namespace _1096
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
                J = 7;
                I += 2;
            }
        }
    }
}
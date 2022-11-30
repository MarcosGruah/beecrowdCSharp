namespace _1074
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (input > 0 && input % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (input > 0 && input % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (input < 0 && input % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (input < 0 && input % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
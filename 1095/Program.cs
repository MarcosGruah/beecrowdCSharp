namespace _1095
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int I = 1;
            int J = 60;

            while (J >= 0)
            {
                Console.WriteLine($"I={I} J={J}");
                I += 3;
                J -= 5;
            }
        }
    }
}
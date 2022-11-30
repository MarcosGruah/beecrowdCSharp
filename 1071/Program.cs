namespace _1071
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> input = new List<int>();
            int total = 0;
            for (int i = 0; i < 2; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            input.Sort();

            for (int i = (input[0] + 1); i < input[1]; i++)
            {
                if (i % 2 != 0)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
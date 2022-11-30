namespace _1099
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                Array.Sort(input);
                List<int> oddNumbers = new List<int>();

                for (int x = (input[0] + 1); x < input[1]; x++)
                {
                    if (x % 2 != 0)
                    {
                        oddNumbers.Add(x);
                    }
                }
                Console.WriteLine(oddNumbers.Sum());
            }
        }
    }
}
namespace _1101
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
                Array.Sort(input);

                if (input[0] <= 0 || input[1] <= 0)
                {
                    break;
                }
                else
                {
                    int total = 0;

                    for (int i = input[0]; i <= input[1]; i++)
                    {
                        Console.Write($"{i} ");
                        total += i;
                    }

                    Console.Write($"Sum={total}");
                    Console.WriteLine();
                }
            } while (true);
        }
    }
}
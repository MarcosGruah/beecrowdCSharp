namespace _1115
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (input[0] == 0 || input[1] == 0)
                {
                    break;
                }
                else if (input[0] > 0 && input[1] > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (input[0] > 0 && input[1] < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (input[0] < 0 && input[1] > 0)
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    Console.WriteLine("terceiro");
                }
            } while (true);
        }
    }
}
namespace _1113
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isActive = true;
            do
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (input[0] == input[1])
                {
                    isActive = false;
                    break;
                }
                else if (input[0] > input[1])
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            } while (isActive);
        }
    }
}
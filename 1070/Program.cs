namespace _1070
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                if (input % 2 != 0)
                {
                    Console.WriteLine(input);
                    input++;
                }
                else
                {
                    input++;
                }
            }
        }
    }
}
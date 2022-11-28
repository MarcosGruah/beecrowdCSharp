namespace _1041
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double X = double.Parse(input[0]);
            double Y = double.Parse(input[1]);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0 && (Y > 0 || Y < 0))
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0 && (X > 0 || X < 0))
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            bool toLouco = true;
        }
    }
}
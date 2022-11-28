namespace _1013
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            int highestNumberAB = (A + B + (Math.Abs(A - B))) / 2;
            int highestNumberC = (C + highestNumberAB + (Math.Abs(C - highestNumberAB))) / 2;

            Console.WriteLine($"{highestNumberC} eh o maior");
        }
    }
}
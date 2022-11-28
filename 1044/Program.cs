namespace _1044
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
            int A = inputNumbers[0];
            int B = inputNumbers[1];

            if (A > B && A % B == 0 || B > A && B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
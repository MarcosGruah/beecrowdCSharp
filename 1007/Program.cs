namespace _1007
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int DIFERENCA = ((A * B) - (C * D));

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
    }
}
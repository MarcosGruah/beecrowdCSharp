namespace _1010
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] produto1 = Console.ReadLine().Split(" ");
            string[] produto2 = Console.ReadLine().Split(" ");

            double total1 = int.Parse(produto1[1]) * double.Parse(produto1[2]);
            double total2 = int.Parse(produto2[1]) * double.Parse(produto2[2]);

            Console.WriteLine($"VALOR A PAGAR: R$ {(total1 + total2).ToString("0.00")}");
        }
    }
}
namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendasMes = double.Parse(Console.ReadLine());

            double totalAReceber = salarioFixo + (totalVendasMes * 0.15);

            Console.WriteLine($"TOTAL = R$ {totalAReceber.ToString("0.00")}");
        }
    }
}
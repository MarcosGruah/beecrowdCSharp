namespace _1014
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int distanciaTotal = int.Parse(Console.ReadLine());
            double totalCombustivelGasto = double.Parse(Console.ReadLine());

            double consumoMedio = distanciaTotal / totalCombustivelGasto;

            Console.WriteLine($"{consumoMedio:F3} km/l");
        }
    }
}
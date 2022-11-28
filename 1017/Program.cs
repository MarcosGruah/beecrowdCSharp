namespace _1017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double tempoViagemHoras = double.Parse(Console.ReadLine());
            double velocidadeMediaKm = double.Parse(Console.ReadLine());
            double consumoPorKm = 12;

            double totalKm = tempoViagemHoras * velocidadeMediaKm;

            double combustivelNecessario = totalKm / consumoPorKm;

            Console.WriteLine($"{combustivelNecessario:F3}");
        }
    }
}
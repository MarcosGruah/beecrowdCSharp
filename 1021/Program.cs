namespace _1021
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{(int)(input / 100)} nota(s) de R$ 100.00");
            input = input % 100;
            Console.WriteLine($"{(int)input / 50} nota(s) de R$ 50.00");
            input = input % 50;
            Console.WriteLine($"{(int)input / 20} nota(s) de R$ 20.00");
            input = input % 20;
            Console.WriteLine($"{(int)input / 10} nota(s) de R$ 10.00");
            input = input % 10;
            Console.WriteLine($"{(int)input / 5} nota(s) de R$ 5.00");
            input = input % 5;
            Console.WriteLine($"{(int)input / 2} nota(s) de R$ 2.00");
            input = input % 2;

            input *= 100;
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{Math.Floor(input / 100)} moeda(s) de R$ 1.00");
            input = input % 100;
            Console.WriteLine($"{Math.Floor(input / 50)} moeda(s) de R$ 0.50");
            input = input % 50;
            Console.WriteLine($"{Math.Floor(input / 25)} moeda(s) de R$ 0.25");
            input = input % 25;
            Console.WriteLine($"{Math.Floor(input / 10)} moeda(s) de R$ 0.10");
            input = input % 10;
            Console.WriteLine($"{Math.Floor(input / 5)} moeda(s) de R$ 0.05");
            input = input % 5;
            Console.WriteLine($"{Math.Floor(input / 1)} moeda(s) de R$ 0.01");
        }
    }
}
namespace _1018
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input);
            Console.WriteLine($"{input / 100} nota(s) de R$ 100,00");
            input = input % 100;
            Console.WriteLine($"{input / 50} nota(s) de R$ 50,00");
            input = input % 50;
            Console.WriteLine($"{input / 20} nota(s) de R$ 20,00");
            input = input % 20;
            Console.WriteLine($"{input / 10} nota(s) de R$ 10,00");
            input = input % 10;
            Console.WriteLine($"{input / 5} nota(s) de R$ 5,00");
            input = input % 5;
            Console.WriteLine($"{input / 2} nota(s) de R$ 2,00");
            input = input % 2;
            Console.WriteLine($"{input / 1} nota(s) de R$ 1,00");
        }
    }
}
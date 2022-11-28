namespace _1020
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int ano = input / 365;
            input %= 365;
            int mes = input / 30;
            input %= 30;
            int dia = input;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}
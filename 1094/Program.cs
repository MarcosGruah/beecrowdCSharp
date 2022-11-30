namespace _1094
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double coelhos = 0;
            double ratos = 0;
            double sapos = 0;

            for (int i = 0; i < count; i++)
            {
                string[] animals = Console.ReadLine().Split();

                if (animals[1] == "C")
                {
                    coelhos += double.Parse(animals[0]);
                }
                else if (animals[1] == "R")
                {
                    ratos += double.Parse(animals[0]);
                }
                else if (animals[1] == "S")
                {
                    sapos += double.Parse(animals[0]);
                }
            }

            Console.WriteLine($"Total: {coelhos + ratos + sapos} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {((coelhos * 100) / (coelhos + ratos + sapos)):F2} %");
            Console.WriteLine($"Percentual de ratos: {((ratos * 100) / (coelhos + ratos + sapos)):F2} %");
            Console.WriteLine($"Percentual de sapos: {((sapos * 100) / (coelhos + ratos + sapos)):F2} %");
        }
    }
}
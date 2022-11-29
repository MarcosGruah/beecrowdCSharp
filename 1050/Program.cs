namespace _1050
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var areaCodes = new[] {
                new { ddd = 61, city = "Brasilia" },
                new { ddd = 71, city = "Salvador" },
                new { ddd = 11, city = "Sao Paulo" },
                new { ddd = 21, city = "Rio de Janeiro" },
                new { ddd = 32, city = "Juiz de Fora" },
                new { ddd = 19, city = "Campinas" },
                new { ddd = 27, city = "Vitoria" },
                new { ddd = 31, city = "Belo Horizonte" } };

            var output = areaCodes.SingleOrDefault(item => item.ddd == input);

            if (output == null)
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            else
            {
                Console.WriteLine(output.city);
            }
        }
    }
}
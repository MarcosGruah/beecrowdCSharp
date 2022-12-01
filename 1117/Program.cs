namespace _1117
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            do
            {
                double input = double.Parse(Console.ReadLine());

                if (input >= 0 && input <= 10)
                {
                    notas.Add(input);
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            } while (notas.Count < 2);

            Console.WriteLine($"media = {(notas.Sum() / 2).ToString("0.##")}");
        }
    }
}
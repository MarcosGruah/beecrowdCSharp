namespace _1118
{
    internal class Program
    {
        public static void CalcularNotas()
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

            Console.WriteLine($"media = {(notas.Sum() / 2).ToString("0.00")}");
        }

        private static void Main(string[] args)
        {
            bool continueProgram = true;
            do
            {
                CalcularNotas();
                bool validOption = true;
                while (validOption)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 2)
                    {
                        continueProgram = false;
                        break;
                    }
                    else if (input == 1)
                    {
                        CalcularNotas();
                    }
                }
            } while (continueProgram);
        }
    }
}
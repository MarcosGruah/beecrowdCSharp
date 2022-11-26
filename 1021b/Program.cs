namespace _1021b
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            double[] moedas = { 1, 0.5, 0.25, 0.1, 0.05, 0.01 };

            double input = 576.73;//Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < notas.Length; i++)
            {
                int qntNotas = (int)(input / notas[i]);
                Console.WriteLine($"{qntNotas} nota(s) de R$ {(notas[i]):F2}");
                input -= qntNotas * notas[i];
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < moedas.Length; i++)
            {
                int qntMoedas = (int)(input / moedas[i]);
                Console.WriteLine($"{qntMoedas} moeda(s) de R$ {(moedas[i]):F2}");
                input -= qntMoedas * moedas[i];
            }

            Console.WriteLine(input);
        }
    }
}
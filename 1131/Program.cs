namespace _1131
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int vitorasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int games = 0;

            do
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (input[0] > input[1])
                {
                    vitorasInter++;
                    games++;
                }
                else if (input[0] < input[1])
                {
                    vitoriasGremio++;
                    games++;
                }
                else
                {
                    empates++;
                    games++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int continueProgram = int.Parse(Console.ReadLine());

                if (continueProgram == 2)
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"{games} grenais");
            Console.WriteLine($"Inter:{vitorasInter}");
            Console.WriteLine($"Gremio:{vitoriasGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vitorasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitorasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}
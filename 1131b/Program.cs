namespace _1131b
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> gamesResult = new List<string>();
            do
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
                if (input[0] > input[1])
                {
                    gamesResult.Add("Internacional");
                }
                else if (input[0] < input[1])
                {
                    gamesResult.Add("Gremio");
                }
                else
                {
                    gamesResult.Add("Empate");
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");

                int addOtherGame = int.Parse(Console.ReadLine());

                if (addOtherGame == 2)
                {
                    break;
                }
            } while (true);

            int vitoriasInternacional = gamesResult.Where(x => x.Equals("Internacional")).Count();
            int vitoriasGremio = gamesResult.Where(x => x.Equals("Gremio")).Count();
            int empates = gamesResult.Where(x => x.Equals("Empate")).Count();

            Console.WriteLine($"{gamesResult.Count} grenais");
            Console.WriteLine($"Inter:{vitoriasInternacional}");
            Console.WriteLine($"Gremio:{vitoriasGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vitoriasInternacional > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}
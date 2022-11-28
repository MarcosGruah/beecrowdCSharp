namespace _1046
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
            DateTime startTime = new DateTime(2022, 01, 01, inputNumbers[0], inputNumbers[1], 0);
            DateTime endTime = new DateTime(2022, 01, 01, inputNumbers[2], inputNumbers[3], 0);

            if (startTime == endTime)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (endTime < startTime)
            {
                endTime = new DateTime(2022, 01, 02, inputNumbers[1], 0, 0);
                Console.WriteLine($"O JOGO DUROU {(endTime - startTime).Hours} HORA(S) E {(endTime - startTime).Minutes} MINUTO(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {(endTime - startTime).Hours} HORA(S) E {(endTime - startTime).Minutes} MINUTO(S)");
            }
        }
    }
}
namespace _1046
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
            DateTime startTime = new DateTime(2022, 01, 01, inputNumbers[0], inputNumbers[1], 0);
            DateTime endTime;

            if (inputNumbers[2] < inputNumbers[0])
            {
                endTime = new DateTime(2022, 01, 02, inputNumbers[2], inputNumbers[3], 0);
            }
            else
            {
                endTime = new DateTime(2022, 01, 02, inputNumbers[2], inputNumbers[3], 0);
            }

            TimeSpan matchDuration = endTime - startTime;

            Console.WriteLine($"O JOGO DUROU {(matchDuration.Days * 24) + matchDuration.Hours} HORA(S) E {matchDuration.Minutes} MINUTO(S)");
        }
    }
}
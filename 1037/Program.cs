namespace _1037
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());

            float[] validNumbers = { 0, 25, 50, 75, 100 };

            if (input >= validNumbers[0] && input <= validNumbers[1])
            {
                Console.WriteLine($"Intervalo [{validNumbers[0]},{validNumbers[1]}]");
            }
            else if (input > validNumbers[1] && input <= validNumbers[2])
            {
                Console.WriteLine($"Intervalo ({validNumbers[1]},{validNumbers[2]}]");
            }
            else if (input > validNumbers[2] && input <= validNumbers[3])
            {
                Console.WriteLine($"Intervalo ({validNumbers[2]},{validNumbers[3]}]");
            }
            else if (input > validNumbers[3] && input <= validNumbers[4])
            {
                Console.WriteLine($"Intervalo ({validNumbers[3]},{validNumbers[4]}]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
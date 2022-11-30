namespace _1079
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double[] inputValues = Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S));

                double total = ((inputValues[0] * 2) + (inputValues[1] * 3) + (inputValues[2] * 5)) / 10;

                Console.WriteLine($"{total:F1}");
            }
        }
    }
}
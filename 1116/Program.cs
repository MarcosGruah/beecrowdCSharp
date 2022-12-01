namespace _1116
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double[] input = Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S));
                if (input[1] == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisionResult = input[0] / input[1];
                    Console.WriteLine(divisionResult.ToString("0.0#"));
                }
            }
        }
    }
}
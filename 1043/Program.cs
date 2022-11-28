namespace _1043
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S));
            double A = inputNumbers[0];
            double B = inputNumbers[1];
            double C = inputNumbers[2];
            double P = (A + B + C) / 2;
            double traingleArea = Math.Sqrt((P * (P - A) * (P - B) * (P - C)));

            if (traingleArea > 0)
            {
                Console.WriteLine($"Perimetro = {(A + B + C):F1}");
            }
            else
            {
                double trapezioArea = ((A + B) * C) / 2;
                Console.WriteLine($"Area = {trapezioArea:F1}");
            }
        }
    }
}
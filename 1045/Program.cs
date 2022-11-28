namespace _1045
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S));
            double[] inputSorted = new double[inputNumbers.Length];
            Array.Copy(inputNumbers, inputSorted, inputNumbers.Length);
            Array.Sort(inputSorted);
            Array.Reverse(inputSorted);
            double A = inputSorted[0];
            double B = inputSorted[1];
            double C = inputSorted[2];
            bool isTriangle;

            if (A >= (B + C))
            {
                isTriangle = false;
                Console.WriteLine($"NAO FORMA TRIANGULO");
            }
            else
            {
                isTriangle = true;
            }

            if (isTriangle)
            {
                if (Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(A, 2) < (Math.Pow(B, 2) + Math.Pow(C, 2)))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
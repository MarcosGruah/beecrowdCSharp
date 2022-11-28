namespace _1012
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double C = double.Parse(input[2]);

            double areaTriangulo = (A * C) / 2;
            double areaCirculo = 3.14159 * (C * C);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
        }
    }
}
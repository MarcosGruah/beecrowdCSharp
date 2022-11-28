namespace _1015
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] point1 = Console.ReadLine().Split();
            string[] point2 = Console.ReadLine().Split();

            double distancia = Math.Sqrt(Math.Pow((double.Parse(point2[0]) - double.Parse(point1[0])), 2) + Math.Pow((double.Parse(point2[1]) - double.Parse(point1[1])), 2));

            Console.WriteLine($"{distancia:F4}");
        }
    }
}
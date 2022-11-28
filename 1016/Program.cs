namespace _1016
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1h Distancia = 30.
            // 60min = Dist(30km)
            // Xmin  = inputDistance

            int inputDistance = int.Parse(Console.ReadLine());
            int result = (60 * inputDistance) / 30;
            Console.WriteLine($"{result} minutos");
        }
    }
}
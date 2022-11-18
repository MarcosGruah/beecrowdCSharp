namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double PI = 3.14159;
            double volumeEsfera = (4.0 / 3.0) * PI * (R * R * R);

            Console.WriteLine($"VOLUME = {volumeEsfera:F3}");
        }
    }
}
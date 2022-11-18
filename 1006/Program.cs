namespace _1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A = float.Parse(Console.ReadLine());
            float B = float.Parse(Console.ReadLine());
            float C = float.Parse(Console.ReadLine());

            double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("0.0")}");

        }
    }
}
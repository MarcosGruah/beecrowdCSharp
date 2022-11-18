namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A = float.Parse(Console.ReadLine());
            float B = float.Parse(Console.ReadLine());

            double MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("0.00000")}");


        }
    }
}

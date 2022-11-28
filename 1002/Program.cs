namespace _1002
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double N = 3.14159;
            double R = double.Parse(Console.ReadLine());

            double areaOfCircle = N * (R * R);

            Console.WriteLine($"A={areaOfCircle.ToString("#.0000")}");
        }
    }
}
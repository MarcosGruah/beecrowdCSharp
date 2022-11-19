namespace _1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int hour = input / 3600;
            int minute = (input - hour * 3600) / 60;
            int second = input - hour * 3600 - minute * 60;

            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}
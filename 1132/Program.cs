namespace _1132
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int total = 0;

            list.Add(int.Parse(Console.ReadLine()));
            list.Add(int.Parse(Console.ReadLine()));
            list.Sort();

            for (int i = list[0]; i <= list[1]; i++)
            {
                if (i % 13 != 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
namespace _1052
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var areaCodes = new[] {
                new { month = 1, name = "January" },
                new { month = 2, name = "February" },
                new { month = 3, name = "March" },
                new { month = 4, name = "April" },
                new { month = 5, name = "May" },
                new { month = 6, name = "June" },
                new { month = 7, name = "July" },
                new { month = 8, name = "August" },
                new { month = 9, name = "September" },
                new { month = 10, name = "October" },
                new { month = 11, name = "November" },
                new { month = 12, name = "December" } };

            var output = areaCodes.SingleOrDefault(item => item.month == input);
            Console.WriteLine(output.name);
        }
    }
}
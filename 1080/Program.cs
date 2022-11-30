namespace _1080
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> inputList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                inputList.Add(int.Parse(Console.ReadLine()));
            }

            int highestNumber = 0;
            int highestNumberIndex = 0;
            int index = 0;

            foreach (var number in inputList)
            {
                index++;

                if (number > highestNumber)
                {
                    highestNumber = number;
                    highestNumberIndex = index;
                }
            }

            Console.WriteLine(highestNumber);
            Console.WriteLine(highestNumberIndex);
        }
    }
}
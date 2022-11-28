namespace _1042
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
            int[] inputSorted = new int[inputNumbers.Length];
            Array.Copy(inputNumbers, inputSorted, inputNumbers.Length);
            Array.Sort(inputSorted);
            Array.ForEach(inputSorted, x => Console.WriteLine(x));
            Console.WriteLine();
            Array.ForEach(inputNumbers, x => Console.WriteLine(x));
        }
    }
}
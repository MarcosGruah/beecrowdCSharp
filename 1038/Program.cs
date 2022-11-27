namespace _1038
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = (Console.ReadLine().Split());

            int code = int.Parse(input[0]);
            int quant = int.Parse(input[1]);
            double totalPrice;

            if (code == 1)
            {
                double itemPrice = 4.00;
                totalPrice = quant * itemPrice;
                Console.WriteLine($"Total: R$ {totalPrice:F2}");
            }
            else if (code == 2)
            {
                double itemPrice = 4.50;
                totalPrice = quant * itemPrice;
                Console.WriteLine($"Total: R$ {totalPrice:F2}");
            }
            else if (code == 3)
            {
                double itemPrice = 5.00;
                totalPrice = quant * itemPrice;
                Console.WriteLine($"Total: R$ {totalPrice:F2}");
            }
            else if (code == 4)
            {
                double itemPrice = 2.00;
                totalPrice = quant * itemPrice;
                Console.WriteLine($"Total: R$ {totalPrice:F2}");
            }
            else if (code == 5)
            {
                double itemPrice = 1.50;
                totalPrice = quant * itemPrice;
                Console.WriteLine($"Total: R$ {totalPrice:F2}");
            }
        }
    }
}
namespace _1048
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double input = double.Parse((Console.ReadLine()));
            double[] increaseRate = { 0.15, 0.12, 0.1, 0.07, 0.04 };
            double newSalary, incomeIncrease;

            if (input >= 0 && input <= 400.00)
            {
                incomeIncrease = (input * increaseRate[0]);
                newSalary = input + incomeIncrease;
                Console.WriteLine($"Novo salario: {newSalary:F2}");
                Console.WriteLine($"Reajuste ganho: {incomeIncrease:F2}");
                Console.WriteLine($"Em percentual: {increaseRate[0] * 100} %");
            }
            else if (input > 400 && input <= 800)
            {
                incomeIncrease = (input * increaseRate[1]);
                newSalary = input + incomeIncrease;
                Console.WriteLine($"Novo salario: {newSalary:F2}");
                Console.WriteLine($"Reajuste ganho: {incomeIncrease:F2}");
                Console.WriteLine($"Em percentual: {increaseRate[1] * 100} %");
            }
            else if (input > 800 && input <= 1200)
            {
                incomeIncrease = (input * increaseRate[2]);
                newSalary = input + incomeIncrease;
                Console.WriteLine($"Novo salario: {newSalary:F2}");
                Console.WriteLine($"Reajuste ganho: {incomeIncrease:F2}");
                Console.WriteLine($"Em percentual: {increaseRate[2] * 100} %");
            }
            else if (input > 1200 && input <= 2000)
            {
                incomeIncrease = (input * increaseRate[3]);
                newSalary = input + incomeIncrease;
                Console.WriteLine($"Novo salario: {newSalary:F2}");
                Console.WriteLine($"Reajuste ganho: {incomeIncrease:F2}");
                Console.WriteLine($"Em percentual: {(increaseRate[3] * 100):F0} %");
            }
            else
            {
                incomeIncrease = (input * increaseRate[4]);
                newSalary = input + incomeIncrease;
                Console.WriteLine($"Novo salario: {newSalary:F2}");
                Console.WriteLine($"Reajuste ganho: {incomeIncrease:F2}");
                Console.WriteLine($"Em percentual: {increaseRate[4] * 100} %");
            }
        }
    }
}
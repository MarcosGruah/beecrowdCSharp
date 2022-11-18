namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double salarioHora = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * salarioHora;

            Console.WriteLine($"NUMBER = {codigoFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("0.00")}");
        }
    }
}
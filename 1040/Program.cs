namespace _1040
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double N1 = double.Parse(input[0]);
            double N2 = double.Parse(input[1]);
            double N3 = double.Parse(input[2]);
            double N4 = double.Parse(input[3]);
            double average = Math.Round(((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10, 1);
            double notaExame;

            Console.WriteLine($"Media: {average:F1}");

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame:F1}");
                if ((average + notaExame) / 2.0 >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {((average + notaExame) / 2.0):F1}");
            }
        }
    }
}
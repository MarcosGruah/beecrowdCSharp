namespace _1114
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            } while (true);
        }
    }
}
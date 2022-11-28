namespace _1049
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            if (input1 == "vertebrado" && input2 == "ave" && input3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (input1 == "vertebrado" && input2 == "ave" && input3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (input1 == "vertebrado" && input2 == "mamifero" && input3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (input1 == "vertebrado" && input2 == "mamifero" && input3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }

            if (input1 == "invertebrado" && input2 == "inseto" && input3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (input1 == "invertebrado" && input2 == "inseto" && input3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (input1 == "invertebrado" && input2 == "anelideo" && input3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (input1 == "invertebrado" && input2 == "anelideo" && input3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}
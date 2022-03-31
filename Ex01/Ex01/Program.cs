namespace Ex01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            pessoa1.Nome = "Emily";
            pessoa1.Idade = 17;
            pessoa2.Nome = "João";
            pessoa2.Idade = 16;


           /* Console.WriteLine("Digite o nome da primeira pessoa: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da primeira pessoa: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade da segunda pessoa: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.ReadKey();
            Console.Clear(); */

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine($"Nome: {pessoa1.Nome}");
            Console.WriteLine($"Idade: {pessoa1.Idade}");
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine($"Nome: {pessoa2.Nome}");
            Console.WriteLine($"Idade: {pessoa2.Idade}");

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }
        }
    }
}

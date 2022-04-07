using System.Globalization;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito? (s/n): ");
            char simOuNao = char.Parse(Console.ReadLine());

            if (simOuNao == 's' || simOuNao == 'S')
            {
                Console.Write("Digite o valor a ser depositado: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta,  nomeTitular, valorDeposito);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine("Dados da conta: \n" + conta);
            Console.WriteLine();

            Console.Write("Digite o valor para depósito: ");
            double valorDeposito1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito1);
            Console.WriteLine();


            Console.WriteLine("Dados atualizados da conta: \n" + conta);
            Console.WriteLine();

            Console.Write("Digite o valor que deseja sacar: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados da conta: \n" + conta);

        }
    }
}

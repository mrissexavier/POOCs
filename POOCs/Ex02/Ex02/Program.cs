using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            funcionario1.Nome = "Carlos Silva";
            funcionario1.Salario = 6300.00;
            funcionario2.Nome = "Ana Marques";
            funcionario2.Salario = 6700.00;

            double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine($"Nome: {funcionario1.Nome}");
            Console.WriteLine("Salário: R$" + funcionario1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine($"Nome: {funcionario2.Nome}");
            Console.WriteLine("Salário: R$" + funcionario2.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Salário médio = R$" + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
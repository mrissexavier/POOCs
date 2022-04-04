using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + produto1);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados do produto: " + produto1);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados do produto: " + produto1);


        }
    }
}

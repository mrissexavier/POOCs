using Construtor;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new("TV", 500.00, 10);

            produto.Nome = "TV 4K";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto);

            
        }
    }
}

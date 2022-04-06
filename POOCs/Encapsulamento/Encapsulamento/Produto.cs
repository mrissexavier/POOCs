using System.Globalization;
namespace Construtor
{
    internal class Produto
    {
        private string _nome;

        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
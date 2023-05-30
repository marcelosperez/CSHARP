using System.Globalization;
namespace Curso
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        //setters and getters


        public void SetNome(string nome) 
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int GetQuantidade()
        {
            return quantidade;
        }



        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            this. quantidade -= quantidade;
        }
        public override string ToString()
        {
            return nome
            + ", $ "
            + preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

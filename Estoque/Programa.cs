using System;
using System.Globalization;

namespace Curso
{
    class Programa
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            produto.SetNome(nome);

            Console.Write("Preço: ");
            double  preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.SetPreco(preco);
            
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.SetQuantidade(quantidade);

            Console.WriteLine(" "); // blank line

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos que serao adicionados ao estoque: ");
            int quantidadeAdicionados = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidadeAdicionados);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos que serao removidos do estoque: ");
            int quantidadeRemovidos = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidadeRemovidos);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

        }
    }
}
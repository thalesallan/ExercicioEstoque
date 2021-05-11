using System;
using System.Globalization;

namespace ExercicioEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a serem Adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite a quantidade de produtos a serem Removidos:");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dados Atualizados " + p);
        }
    }
}

using DapperLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProductRepository();

            var listaProdutos = repository.ObterProdutos();
            var forPrint = listaProdutos.Where(p => p.ProductSubcategoryID.HasValue).Take(10).ToList();
            forPrint.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("---------------");

            var produto = repository.ObterProdutoPorID(780);
            Console.WriteLine(produto.ToString());

            Console.ReadKey();
        }
    }
}

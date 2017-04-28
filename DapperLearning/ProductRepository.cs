using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using DapperLearning.Model;
using System.Data.SqlClient;

namespace DapperLearning
{
    public class ProductRepository
    {
        private string dbConnectionString = AppConnectionString.GetConnectionString();
        
        /// <summary>
        /// Obtem todos os produtos
        /// </summary>
        public List<Product> ObterProdutos()
        {
            var Produtos = new List<Product>();

            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                //var result = conn.Query<Product>("SELECT * FROM Production.Product");
                
                //Também poderiamos usar Dapper.Contrib: 
                var result = conn.GetAll<Product>();

                if (result.Any())
                    Produtos = result.ToList();
            }

            return Produtos;
        }
        
        /// <summary>
        /// Obtem um produto pelo seu ID
        /// </summary>
        public Product ObterProdutoPorID(int productID)
        {
            var Produto = new Product();

            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                var query = @"SELECT * FROM Production.Product WHERE ProductID = @ID";
                var result = conn.Query<Product>(query, new { ID = productID });

                //Também poderiamos usar Dapper.Contrib: 
                //var result = conn.Get<Product>(productID);

                if (result.Any())
                    Produto = result.FirstOrDefault();
            }

            return Produto;
        }
    }
}

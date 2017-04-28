using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace DapperLearning.Model
{
    [Table("Production.Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }

        public int SafetyStockLevel { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }

        public int? ProductSubcategoryID { get; set; }
        public int? ProductModelID { get; set; }

        public override string ToString()
        {
            var cor = string.IsNullOrEmpty(Color) ? "Indefinido" : Color;
            return string.Format("Produto: {0}({1}), Cor: {2}, Preço: {3:C}", Name, ProductNumber, cor, ListPrice);
        }
    }
}

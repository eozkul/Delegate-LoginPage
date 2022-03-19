using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Concretes
{
    public class ProductService : IProductService
    {
        private DatabaseManager databaseManager;
        public ProductService()
        {
            databaseManager = new DatabaseManager();
        }
        public List<Product> GetAllProducts()
        {
            var query = "SELECT * FROM Products";
            return databaseManager.GetAllWithDapper(query);
        }
    }


    
}

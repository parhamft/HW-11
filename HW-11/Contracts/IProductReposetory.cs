using HW_11.Entities;
using HW_11.Enums;
using HW_11.Reposetories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11.Contracts
{
    public interface IProductReposetory
    {
        public void AddProduct(Product P);
        public List<Product> GetAllProducts();

        public void Update(int id, string name, CategorieEnum categoryId, int price);
        public void Delete(int id);
        public Product GetById(int id);
    }
}

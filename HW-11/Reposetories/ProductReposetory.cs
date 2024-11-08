using HW_11.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using HW_11.Enums;
using System.Diagnostics;
using System.Xml.Linq;
using HW_11.Contracts;

namespace HW_11.Reposetories
{
    public class ProductReposetory : IProductReposetory
    {
        readonly string conectionString = "Server = DESKTOP-03R7JG5\\SQLEXPRESS; Database=ShopDb;Trusted_Connection=True;";
        public void AddProduct(Product P)
        {
            using (IDbConnection db = new SqlConnection(conectionString))
            {
                db.Execute(UserQuery.create, new {P.Id,P.Name, P.CategoryId, P.Price });
            }

        }
        public List<Product> GetAllProducts()
        {
            using (IDbConnection db = new SqlConnection(conectionString))
            {
                return db.Query<Product>(UserQuery.Get).ToList();
            }
        }

        public void Update(int id, string name, CategorieEnum categoryId, int price)
        {
            using (IDbConnection db = new SqlConnection(conectionString))
            {
                db.Execute(UserQuery.Update, new { Id = id, Name = name, CategoryId= categoryId, Price = price });
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(conectionString))
            {
                db.Execute(UserQuery.delete, new { Id = id });
            }
        }
        public Product GetById(int id)
        {
            using (IDbConnection db = new SqlConnection(conectionString))
            {
                var product = db.QueryFirstOrDefault<Product>(UserQuery.GetById, new { Id = id });
                return product;
            }
        }

    }
}

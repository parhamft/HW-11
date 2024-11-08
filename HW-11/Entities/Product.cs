using HW_11.Contracts;
using HW_11.Enums;
using HW_11.Reposetories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategorieEnum CategoryId { get; set; }
        public int Price { get; set; }
        IProductReposetory repo = new ProductReposetory();

        public Product(string Name, CategorieEnum categoryId, int price)
        {
            this.Id = IdGen();
            this.Name = Name;
            this.CategoryId = categoryId;
            this.Price = price;
        }
        public Product()
        {
            
        }
        public int IdGen()
        {
            int count = repo.GetAllProducts().Count;

            Product tuser = repo.GetAllProducts()[count - 1];
            return tuser.Id+1;
        }
        public string changeName(string name)
        {
            foreach (Product p in repo.GetAllProducts()) { if (p.Name == name) { return "a product with this name already exists"; } }
            this.Name = name;
            return $"product name succesfuly changed to {name}";
        }
        public string changeCategory(CategorieEnum category)
        {
            this.CategoryId = category;
            return $"product category changed to {category}";
        }
        public string changePrice(int price)
        {
            if (price < 0) { return"you cant enter negetive numbers as the price"; }
            this.Price = price;
            return $"products price changed to {price}$";
        }

    }
    
}

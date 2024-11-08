using HW_11.Contracts;
using HW_11.Entities;
using HW_11.Enums;
using HW_11.Reposetories;

namespace HW_11.services
{
    public class ProductServices : IProductServices
    {
        IProductReposetory repo = new ProductReposetory();

        public string Add(string name, CategorieEnum cat, int price)
        {
            foreach (Product p in repo.GetAllProducts())
            {
                if (p.Name == name) { return "a Product with this name already exist"; }
            }
            repo.AddProduct(new Product(name, cat, price));
            return "product added";

        }
        public string showAll()
        {
            string str = "";
            foreach (Product p in repo.GetAllProducts())
            {
                str += $"{p.Id}) {p.Name}  {p.Price}$ | {p.CategoryId}\n";
            }

            return str;
        }
        public string Search(string search)
        {
            string str = "";
            var prod = repo.Search(search);
            if (prod == null)
            {
                return "nothing found";
            }
            foreach (Product p in prod)
            {
                str += $"{p.Id}) {p.Name}   {p.CategoryId} | {p.Price}\n";
            }
            return str;

        }
        public string Update(int id, int options, string New)
        {
            Product prod = null;
            foreach (Product p in repo.GetAllProducts())
            { if (p.Id == id) { prod = p; } }
            switch (options)
            {
                case 1:

                    Console.WriteLine(prod.changeName(New));
                    repo.Update(prod.Id, prod.Name, prod.CategoryId, prod.Price);
                    break;


                case 2:
                    int categoryId = Convert.ToInt32(New);
                    Console.WriteLine(prod.changeCategory((CategorieEnum)categoryId));
                    repo.Update(prod.Id, prod.Name, prod.CategoryId, prod.Price);
                    break;
                case 3:

                    Console.WriteLine(prod.changePrice(Convert.ToInt32(New)));
                    repo.Update(prod.Id, prod.Name, prod.CategoryId, prod.Price);
                    break;
            }
            return "";
        }
        public string delete(int id)
        {
            if (repo.GetById(id) != null)
            {
                repo.Delete(id);
                return "product removed";
            }
            return "product doesnt exist";

        }

    }
}

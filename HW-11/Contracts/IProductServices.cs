using HW_11.Entities;
using HW_11.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11.Contracts
{
    public interface IProductServices
    {
        public string Add(string name, CategorieEnum cat, int price);
        public string showAll();
        public string Update(int id, int options, string New);
        public string delete(int id);
    }
}

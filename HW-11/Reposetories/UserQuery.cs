using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11.Reposetories
{
    public static class UserQuery
    {
        public static string create = "insert into Products (Id,Name,CategoryId,Price) values (@Id,@Name,@CategoryId, @Price)";
        public static string Get = "select * from Products";
        public static string Update = "Update Products SET Name= @Name,CategoryId=@categoryId,Price=@price where Id = @Id";
        public static string delete = "DELETE FROM Products WHERE Id =@Id;";
        public static string GetById = "select * from Products where Id = @Id";

    }
}

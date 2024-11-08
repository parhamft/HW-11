using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11.Entities
{
    public class Orders
    {
        public int Id{ get; set; }
        public int CustomerId{ get; set; }
        public int ProductId{ get; set; }
        public DateOnly OrderDate {  get; set; }
        public int TotalAmount{ get; set; }
    }
}

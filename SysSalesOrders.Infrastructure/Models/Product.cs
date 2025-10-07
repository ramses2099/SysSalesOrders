using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure.Models
{
    public class Product
    {
        public int ProdId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Discount { get; set; }
        public int UnitPrice { get; set; }
        public decimal Tax { get; set; }

        //Navigation
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

        public DateTime CreatedAt { get; set; }
    }
}

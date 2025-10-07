using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure.Models
{
    public class SalesOrderDetail
    {
        public int SaleOrderDetailId { get; set; }

        // Foreign Key
        public int SaleOrderId { get; set; }

        // Foreign Key
        public int ProdId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTax { get; set; }
        public decimal Total { get; set; }

        // Navigation property back to order
        public required SalesOrder SalesOrder { get; set; }
        public required Product Product { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure.Models
{
    public class SalesOrder
    {
        public int SaleOrderId { get; set; }
        public DateTime SaleOrderDate { get; set; }


        // Foreign Key
        public int CustId { get; set; }

        // Foreign Key
        public int PaymMethId { get; set; }
        
        
        public decimal TotalDiscount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTax { get; set; }
        public decimal Total { get; set; }

        //Navigation
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

        public DateTime CreatedAt { get; set; }
    }
}

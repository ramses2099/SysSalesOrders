using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Domain.Entities
{
    public class SalesOrder
    {
        public int SaleOrderId { get; set; }
        public DateTime SaleOrderDate { get; set; }
        public int CustId { get; set; }
        public int PaymMethId { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalTax { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

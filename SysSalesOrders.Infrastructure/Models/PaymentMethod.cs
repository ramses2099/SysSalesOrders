using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure.Models
{
    public class PaymentMethod
    {
        public int PaymMethId { get; set; }
        public string Description { get; set; } = string.Empty;

        //Navigation
        public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

        public DateTime CreatedAt { get; set; }

    }
}

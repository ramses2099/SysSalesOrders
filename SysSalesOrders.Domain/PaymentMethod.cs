using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Domain
{
    public class PaymentMethod
    {
        public int PaymMethId { get; set; }
        public string Description { get; set; } = string.Empty;      
        public DateTime CreatedAt { get; set; }

    }
}

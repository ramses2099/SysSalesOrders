using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Domain
{
    public class Address
    {
        public int AddId { get; set; }
        public int CustId { get; set; }
        public string Address1 { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}

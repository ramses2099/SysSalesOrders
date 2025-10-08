using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Domain.Entities
{
    public class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

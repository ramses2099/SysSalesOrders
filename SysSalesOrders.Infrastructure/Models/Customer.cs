using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure.Models
{
    public class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //Navigation
        public ICollection<SalesOrder> SalesOrder { get; set; } = new List<SalesOrder>();

        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public DateTime CreatedAt { get; set; }
    }
}

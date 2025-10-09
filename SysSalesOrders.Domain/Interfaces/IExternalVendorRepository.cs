using SysSalesOrders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Domain.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<Todo> GetTodo();
    }
}

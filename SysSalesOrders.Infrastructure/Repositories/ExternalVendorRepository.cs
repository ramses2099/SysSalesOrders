using SysSalesOrders.Domain.Interfaces;
using SysSalesOrders.Domain.Models;
using SysSalesOrders.Infrastructure.Services;

namespace SysSalesOrders.Infrastructure.Repositories
{
    public class ExternalVendorRepository: IExternalVendorRepository
    {
        private readonly JsonPlaceHolderHttpClientService _jsonPlaceHolderHttpClientService;

        public ExternalVendorRepository(JsonPlaceHolderHttpClientService jsonPlaceHolderHttpClientService) {
            this._jsonPlaceHolderHttpClientService = jsonPlaceHolderHttpClientService;
        }

        public async Task<Todo> GetTodo()
        {
            return await this._jsonPlaceHolderHttpClientService.GetData();
        }
    }
}

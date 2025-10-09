using SysSalesOrders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SysSalesOrders.Infrastructure.Services
{
    public class JsonPlaceHolderHttpClientService
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceHolderHttpClientService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        public async Task<Todo> GetData() {
            return await _httpClient.GetFromJsonAsync<Todo>("todos/1");
        }

    }


}

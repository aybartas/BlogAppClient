using BlogAppClient.ApiServices.Interfaces;
using BlogAppClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlogAppClient.ApiServices.Services
{
    public class CategoryApiService : ICategoryApiService
    {
        private readonly HttpClient httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("http://localhost:52624/api/categories");
            this.httpClient = httpClient;
        }

        public async Task<List<CategoryListModel>> GetAll()
        {
            var httpResponse = await httpClient.GetAsync("");

            if (httpResponse.IsSuccessStatusCode)
            {
                var deserializedResult = JsonConvert.DeserializeObject<List<CategoryListModel>>
                     (await httpResponse.Content.ReadAsStringAsync());
                return deserializedResult;
            }
            return null;
        }
    }
}

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
    public class BlogApiService : IBlogApiService
    {
        private readonly HttpClient httpClient;
         
        public BlogApiService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("http://localhost:52624/api/blogs");
            this.httpClient = httpClient;   
        }

        public async Task<List<BlogListModel>> GetAll()
        {
            var httpResponse = await httpClient.GetAsync("");

            if (httpResponse.IsSuccessStatusCode)
            {
               var deserializedResult =  JsonConvert.DeserializeObject<List<BlogListModel>>
                    (await httpResponse.Content.ReadAsStringAsync());
                return deserializedResult;
            }
            return null;
            
        }
    }
}

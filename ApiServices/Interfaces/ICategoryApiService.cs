using BlogAppClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAppClient.ApiServices.Interfaces
{
   public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAll();

    }
}

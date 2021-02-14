using BlogAppClient.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAppClient.ViewComponents
{
    public class CategoryList: ViewComponent
    {
        private readonly ICategoryApiService categoryApiService;

        public CategoryList(ICategoryApiService categoryApiService)
        {
           this.categoryApiService = categoryApiService;
        }

        public IViewComponentResult Invoke()
        {
            return View(categoryApiService.GetAll().Result);
        }

    }
}

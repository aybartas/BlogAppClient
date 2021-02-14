using BlogAppClient.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAppClient.Controllers
{
    public class HomeController : Controller
    {
       readonly IBlogApiService blogApiService;

        public HomeController(IBlogApiService blogApiService)
        {
            this.blogApiService = blogApiService;
        }


        public async Task<IActionResult> Index()
        {
            var blogs = await blogApiService.GetAll();

            return View(blogs);
        }
    }
}

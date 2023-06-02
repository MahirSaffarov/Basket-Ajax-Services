using Microsoft.AspNetCore.Mvc;
using Molla.Models;
using Molla.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Molla.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Blog> blogs = await _blogService.GetAllAsync();
            return View(blogs);
        }
    }
}

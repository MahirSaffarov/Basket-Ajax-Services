using Microsoft.AspNetCore.Mvc;
using Molla.Models;
using Molla.Service.Interfaces;
using Molla.ViewModels;
using System.Diagnostics;

namespace Molla.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IProductService _productService;
        public HomeController(ISliderService sliderService, IProductService productService)
        {
            _sliderService = sliderService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var slider = await _sliderService.GetSliderAsync();
            var info = await _sliderService.GetInfoAsync();
            var product = await _productService.GetAllAsync();

            HomeVM homeVM = new()
            {
                Infos = info,
                Sliders = slider,
                Products = product
            };
            return View(homeVM);
        }
    }
}
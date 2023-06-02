using Microsoft.AspNetCore.Mvc;
using Molla.Models;
using Molla.Service.Interfaces;
using Molla.ViewModels;

namespace Molla.Controllers
{
    public class AboutController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly ITeamService _teamService;
        public AboutController(IBrandService brandService, ITeamService teamService)
        {
            _brandService = brandService;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var brands = await _brandService.GetAllAsync();
            var teams = await _teamService.GetAllAsync();

            AboutVM aboutVM = new()
            {
                Brands = brands,
                Teams = teams
            };
            return View(aboutVM);
        }
    }
}

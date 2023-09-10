using CASEWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using ServicesLayer.Services.Abstractions;
using System.Diagnostics;

namespace CASEWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEducationService _educationService;
        public HomeController(ILogger<HomeController> logger,IEducationService  educationService)
        {
            _logger = logger;
            _educationService = educationService;
        }

        public async Task<IActionResult> Index()
        {
            var edcuations = await _educationService.GetAllEducation();
            return View(edcuations);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
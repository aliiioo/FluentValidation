using FluentValidationing.DTOs;
using FluentValidationing.Validations;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FluentValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            var Validation = new RegisterValidation();
            var result=await Validation.ValidateAsync(registerViewModel,x=>x.IncludeRuleSets("Bearth"));

            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }

             return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
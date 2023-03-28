using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace SiafManagementStudio.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> _userManager;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {


            ViewBag.x = User.Identity.Name.Replace("@siaf.com.tn", "");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
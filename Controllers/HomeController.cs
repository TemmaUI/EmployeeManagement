using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            ViewBag.ShowWelcomeMessage = true;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

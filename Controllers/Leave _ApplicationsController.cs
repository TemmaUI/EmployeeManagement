using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Controllers
{
    public class Leave_ApplicationsController : Controller
    {
        public IActionResult Approved_Applications()
        {
            return View();
        }

        public IActionResult Submitted_Applications()
        {
            return View();
        }

        public IActionResult Verified_Applications()
        {
            return View();
        }
    }
}
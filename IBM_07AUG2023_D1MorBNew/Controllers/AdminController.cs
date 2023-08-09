using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

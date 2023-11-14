using Microsoft.AspNetCore.Mvc;

namespace webAppCore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace webAppCore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index(string name, int indicator)
        {
            ViewData["name"] = name; // ViewData is a dictionary of objects that is derived from ViewDataDictionary
            ViewData["indicator"] = indicator;
            return View();
        }
    }
}

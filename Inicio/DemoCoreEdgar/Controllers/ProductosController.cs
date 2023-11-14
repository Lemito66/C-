using Microsoft.AspNetCore.Mvc;



namespace webAppDemo33.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Productos()
        {
            return "Este es un texto desde el controlador";
        }
       public string consultarExitencia(int codigo)
        {


            return "Existencia es de : " + codigo.ToString();
        }
    }
}

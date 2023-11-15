using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace webAppDemo33.Controllers
{
    public class clientesController : Controller
    {
        public IActionResult Index(string nombrecliente, int indicador)
        {
            ViewData["NombreCliente"]=nombrecliente;
            ViewData["Indicador"]=indicador;
            return View();
        }

        public string clientesmora(int codigoCliente, int limiteCredito, string nombre)
        {
            return HtmlEncoder.Default.Encode($"Codigo cliente: {codigoCliente} su limite de credito es {limiteCredito} para el cliente {nombre}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCoreApp.Pages
{
    public class ProductsModel : PageModel
    {
        public string MessageData { get; private set; } = "Página Razor de los productos";
        public void OnGet()
        {
            MessageData += $" <br/> Tiempo en el servidor: {DateTime.Now}";
        }
    }
}

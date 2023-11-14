using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace webAppCore.Controllers
{
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "Products";
        }
        public string productoMora(int productCode, int creditLimit, string name)
        {
           return HtmlEncoder.Default.Encode($"Product Code: {productCode}, Credit Limit: {creditLimit}, Name: {name}");
        }
        public string queryExists(int productCode)
        {
            return HtmlEncoder.Default.Encode($"Existencia de: {productCode}");
        }
    }
}

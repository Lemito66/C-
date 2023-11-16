using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebCoreApp.Models;

namespace WebCoreApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Data.ProductsDbContext _dbContext;
        
        public IndexModel(Data.ProductsDbContext context)
        {
            _dbContext = context;
        }
        public IList<Models.Products> Products { get;  set; }

        public async Task OnGetAsync()
        {
            Products = await _dbContext.Products.ToListAsync();
        }

        public void OnGet()
        {

        }



    }
}

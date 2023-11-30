using apiCore.Models;
using Microsoft.EntityFrameworkCore; // Esto se lo instala en los paquetes de NuGet, ahora esta con la  versión 6
namespace apiCore.Context
{
    public class ApplicationDbContext: DbContext
    {
        // Siempre que sea una clase de contexto , debe heredar de DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) // Esto es un constructor que recibe un parametro de tipo DbContextOptions<ApplicationDbContext> y lo pasa al constructor de la clase base DbContext
        {
            
        }
        public DbSet<Customer> Customers { get; set; } // DbSet es una clase que representa una tabla de la base de datos, en este caso Customers es una tabla de la base de datos
    }
}

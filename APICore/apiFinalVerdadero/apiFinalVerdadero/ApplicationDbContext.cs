using Microsoft.EntityFrameworkCore;
using apiFinalVerdadero.Models;

namespace apiFinalVerdadero
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ComentarioEL> ComentarioEL { get; set; } // DbSet es una colección de entidades que se pueden consultar, agregar, actualizar y eliminar de una base de datos.
        protected readonly IConfiguration Configuration; // IConfiguration es una interfaz que proporciona acceso a las configuraciones de la aplicación.

        public ApplicationDbContext(IConfiguration configuration)  // ApplicationDbContext es una clase que hereda de DbContext y se utiliza para configurar una sesión con la base de datos.
        {
            Configuration = configuration; 
        }

        public ApplicationDbContext() { 

        }



        protected override void OnConfiguring(DbContextOptionsBuilder options) // OnConfiguring es un método que se llama cuando se crea el contexto.
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        
    }
}

using CRUD_NetCore7_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NetCore7_Razor.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base (options) { }

        //Modelos --- tablas en la base de datos
        public DbSet<Producto> Producto { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CRUD_NetCore7_Razor.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base (options) { }

        //Modelos --- tablas en la base de datos
    }
}

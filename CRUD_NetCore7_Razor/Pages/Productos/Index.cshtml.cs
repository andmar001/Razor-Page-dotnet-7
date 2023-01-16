using CRUD_NetCore7_Razor.Datos;
using CRUD_NetCore7_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NetCore7_Razor.Pages.Productos
{
    public class IndexModel : PageModel
    {
        //contexto
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Producto> Productos { get; set; }
        public async Task OnGet()
        {
            Productos = await _context.Producto.ToListAsync();
        }
    }
}

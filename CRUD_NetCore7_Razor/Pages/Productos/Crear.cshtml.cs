using CRUD_NetCore7_Razor.Datos;
using CRUD_NetCore7_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetCore7_Razor.Pages.Productos
{
    public class CrearModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CrearModel(ApplicationDbContext context)
        {
            _context = context;
        }
        //Vincular el modelo
        [BindProperty]
        public Producto Producto { get; set; }

        public void OnGet()
        {
        }
    }
}

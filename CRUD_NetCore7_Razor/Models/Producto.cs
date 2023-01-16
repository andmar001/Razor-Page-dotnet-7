using System.ComponentModel.DataAnnotations;

namespace CRUD_NetCore7_Razor.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre del Producto")]
        public string NombreProducto { get; set; } = string.Empty;
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; } = string.Empty;
        [Display(Name = "Cantidad en Stock")]
        public int EnStock { get; set; }
        public int Precio { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }
    }
}

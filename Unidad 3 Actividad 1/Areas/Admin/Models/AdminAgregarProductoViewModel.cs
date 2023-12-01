using Unidad_3_Actividad_1.Models.Entities;

namespace Unidad_3_Actividad_1.Areas.Admin.Models
{
    public class AdminAgregarProductoViewModel
    {
        public Menu menuHamburguesas { get; set; } = new();
        public IEnumerable<Clasificacion> Clasificaciones { get; set; } = null!;
        public IFormFile? Archivo { get; set; }
    }
}

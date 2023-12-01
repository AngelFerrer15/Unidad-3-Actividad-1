using Unidad_3_Actividad_1.Models.Entities;
namespace Unidad_3_Actividad_1.Models.ViewModels
{
    public class MenuViewModel
    {
        public IEnumerable<Clasificacion> ClasificacionesL { get; set; } = null!;

        public int IdSeleccionado { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}

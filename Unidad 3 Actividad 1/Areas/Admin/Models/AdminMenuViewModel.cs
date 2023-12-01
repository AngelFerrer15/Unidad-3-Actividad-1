using Unidad_3_Actividad_1.Models.Entities;

namespace Unidad_3_Actividad_1.Areas.Admin.Models
{
    public class AdminMenuViewModel
    {
        public IEnumerable<Clasificacion> Clasifi { get; set; } = null!;
    }
}

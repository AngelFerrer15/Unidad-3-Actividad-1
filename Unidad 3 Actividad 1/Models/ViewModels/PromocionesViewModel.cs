using Unidad_3_Actividad_1.Models.Entities;
namespace Unidad_3_Actividad_1.Models.ViewModels
{
    public class PromocionesViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public decimal Promocion { get; set; }
        public int IndexI { get; set; }
        public int IndexF { get; set; }
    }
}

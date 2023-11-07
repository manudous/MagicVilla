using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.DTO
{
    public class VillaUpdateDto
    {
        [Required(ErrorMessage = "El id de la villa es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la villa es requerido")]
        [MaxLength(30, ErrorMessage = "El nombre de la villa no puede ser mayor a 30 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        public string Detalle { get; set; } = string.Empty;
        [Required(ErrorMessage = "La tarifa de la villa es requerida")]
        public double Tarifa { get; set; }
        [Required(ErrorMessage = "El número de ocupantes de la villa es requerido")]
        public int Ocupantes { get; set; }
        [Required(ErrorMessage = "El número de metros cuadrados de la villa es requerido")]
        public int MetrosCuadrados { get; set; }
        [Required(ErrorMessage = "La imagen de la villa es requerida")]
        public string ImageUrl { get; set; } = string.Empty;
        public string Amenidad { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.DTO
{
    public class VillaCreateDto
    {

        [Required(ErrorMessage = "El nombre de la villa es requerido")]
        [MaxLength(30, ErrorMessage = "El nombre de la villa no puede ser mayor a 30 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        public string Detalle { get; set; } = string.Empty;
        [Required(ErrorMessage = "La tarifa de la villa es requerida")]
        public double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string Amenidad { get; set; } = string.Empty;
        public object Id { get; internal set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.DTO
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la villa es requerido")]
        [MaxLength(30, ErrorMessage = "El nombre de la villa no puede ser mayor a 30 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
    }
}

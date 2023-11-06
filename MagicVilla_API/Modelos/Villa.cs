using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos
{
    public class Villa
    {
        [Key]
        // Se generará automáticamente un valor único para cada nueva villa
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public string Detalle { get; set; } = string.Empty;
        [Required]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public int MetrosCuadrados { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public string Amenidad { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }    
    }
}

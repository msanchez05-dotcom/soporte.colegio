using System.ComponentModel.DataAnnotations;

namespace SoporteColegio.Models
{
    public class FallaComun
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Equipo { get; set; } = string.Empty; // PC, Proyector, Mouse, etc.

        [Required]
        public string Descripcion { get; set; } = string.Empty; // Ej: "No enciende", "Sin sonido"
    }
}

using System.ComponentModel.DataAnnotations;

namespace SoporteColegio.Models
{
    public class Sala
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nombre { get; set; } = string.Empty; // Ej: "Sala 4B", "Lab de Computación"
    }
}

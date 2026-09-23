using System.ComponentModel.DataAnnotations;
using SoporteColegio.Models;

namespace SoporteColegio.ViewModels;

public class ProfesorTicketViewModel
{
    [Required(ErrorMessage = "Selecciona una sala.")]
    [Display(Name = "Sala")]
    public int? SalaId { get; set; }

    [Required(ErrorMessage = "Selecciona el problema.")]
    [Display(Name = "Problema")]
    public int? FallaComunId { get; set; }

    [StringLength(500, ErrorMessage = "El detalle no puede superar los 500 caracteres.")]
    [Display(Name = "Detalle adicional")]
    public string? DetalleAdicional { get; set; }

    public IReadOnlyList<Sala> Salas { get; set; } = [];
    public IReadOnlyList<FallaComun> FallasComunes { get; set; } = [];
}

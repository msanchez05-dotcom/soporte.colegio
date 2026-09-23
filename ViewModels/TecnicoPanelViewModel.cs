using SoporteColegio.Models;

namespace SoporteColegio.ViewModels;

public class TecnicoPanelViewModel
{
    public IReadOnlyList<Ticket> Tickets { get; set; } = [];
}

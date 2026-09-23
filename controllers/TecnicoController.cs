using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using SoporteColegio.Data;
using SoporteColegio.Hubs;
using SoporteColegio.ViewModels;

namespace SoporteColegio.Controllers;

public class TecnicoController : Controller
{
    private static readonly string[] EstadosPermitidos = ["Pendiente", "En proceso", "Resuelto"];
    private readonly ApplicationDbContext context;
    private readonly IHubContext<SoporteHub> hubContext;

    public TecnicoController(ApplicationDbContext context, IHubContext<SoporteHub> hubContext)
    {
        this.context = context;
        this.hubContext = hubContext;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var tickets = await context.Tickets
            .AsNoTracking()
            .Include(ticket => ticket.Sala)
            .Include(ticket => ticket.FallaComun)
            .OrderBy(ticket => ticket.Estado == "Resuelto")
            .ThenByDescending(ticket => ticket.FechaReporte)
            .ToListAsync();

        return View(new TecnicoPanelViewModel { Tickets = tickets });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ActualizarEstado(int id, string estado)
    {
        if (!EstadosPermitidos.Contains(estado, StringComparer.OrdinalIgnoreCase))
        {
            return BadRequest("Estado no valido.");
        }

        var ticket = await context.Tickets
            .Include(item => item.Sala)
            .Include(item => item.FallaComun)
            .SingleOrDefaultAsync(item => item.Id == id);

        if (ticket is null)
        {
            return NotFound();
        }

        ticket.Estado = EstadosPermitidos.First(item => item.Equals(estado, StringComparison.OrdinalIgnoreCase));
        await context.SaveChangesAsync();

        await hubContext.Clients.All.SendAsync("TicketActualizado", new
        {
            id = ticket.Id,
            estado = ticket.Estado
        });

        return Ok(new { ticket.Id, ticket.Estado });
    }
}

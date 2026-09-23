using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SoporteColegio.Data;
using SoporteColegio.Hubs;
using SoporteColegio.Models;
using SoporteColegio.ViewModels;

namespace SoporteColegio.Controllers;

public class ProfesorController : Controller
{
    private readonly ApplicationDbContext context;
    private readonly IHubContext<SoporteHub> hubContext;

    public ProfesorController(ApplicationDbContext context, IHubContext<SoporteHub> hubContext)
    {
        this.context = context;
        this.hubContext = hubContext;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await CreateViewModelAsync());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Registrar(ProfesorTicketViewModel model)
    {
        if (!ModelState.IsValid)
        {
            model = await CompleteViewModelAsync(model);
            return View("Index", model);
        }

        var salaExists = await context.Salas.AnyAsync(sala => sala.Id == model.SalaId);
        var fallaExists = await context.FallasComunes.AnyAsync(falla => falla.Id == model.FallaComunId);

        if (!salaExists)
        {
            ModelState.AddModelError(nameof(model.SalaId), "La sala seleccionada no existe.");
        }

        if (!fallaExists)
        {
            ModelState.AddModelError(nameof(model.FallaComunId), "El problema seleccionado no existe.");
        }

        if (!ModelState.IsValid)
        {
            model = await CompleteViewModelAsync(model);
            return View("Index", model);
        }

        var ticket = new Ticket
        {
            SalaId = model.SalaId!.Value,
            FallaComunId = model.FallaComunId!.Value,
            DetalleAdicional = model.DetalleAdicional,
            Estado = "Pendiente"
        };
        context.Tickets.Add(ticket);

        await context.SaveChangesAsync();

        var sala = await context.Salas.AsNoTracking().SingleAsync(item => item.Id == model.SalaId);
        var falla = await context.FallasComunes.AsNoTracking().SingleAsync(item => item.Id == model.FallaComunId);
        await hubContext.Clients.All.SendAsync("TicketCreado", new
        {
            id = ticket.Id,
            sala = sala.Nombre,
            equipo = falla.Equipo,
            problema = falla.Descripcion,
            detalle = ticket.DetalleAdicional,
            fecha = ticket.FechaReporte,
            estado = ticket.Estado
        });

        TempData["TicketCreado"] = "Aviso registrado. El equipo de soporte lo revisara pronto.";
        return Redirect("/Profesor");
    }

    private async Task<ProfesorTicketViewModel> CreateViewModelAsync()
    {
        return new ProfesorTicketViewModel
        {
            Salas = await context.Salas.AsNoTracking().OrderBy(sala => sala.Id).ToListAsync(),
            FallasComunes = await context.FallasComunes.AsNoTracking().OrderBy(falla => falla.Equipo).ThenBy(falla => falla.Descripcion).ToListAsync()
        };
    }

    private async Task<ProfesorTicketViewModel> CompleteViewModelAsync(ProfesorTicketViewModel model)
    {
        var options = await CreateViewModelAsync();
        model.Salas = options.Salas;
        model.FallasComunes = options.FallasComunes;
        return model;
    }
}

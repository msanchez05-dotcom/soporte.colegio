using Microsoft.EntityFrameworkCore;
using SoporteColegio.Models;

namespace SoporteColegio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<FallaComun> FallasComunes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        // Esto insertará datos de prueba automáticamente al crear la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sala>().HasData(
                new Sala { Id = 1, Nombre = "Sala 1" },
                new Sala { Id = 2, Nombre = "Sala 2" },
                new Sala { Id = 3, Nombre = "Sala 3" },
                new Sala { Id = 4, Nombre = "Sala 4" },
                new Sala { Id = 5, Nombre = "Sala 5" },
                new Sala { Id = 6, Nombre = "Sala 6" },
                new Sala { Id = 7, Nombre = "Sala 7" },
                new Sala { Id = 8, Nombre = "Sala 8" },
                new Sala { Id = 9, Nombre = "Sala 9" },
                new Sala { Id = 10, Nombre = "Sala 10" },
                new Sala { Id = 11, Nombre = "Sala 11" },
                new Sala { Id = 12, Nombre = "Sala 12" },
                new Sala { Id = 13, Nombre = "Sala 13" },
                new Sala { Id = 14, Nombre = "Sala 14" },
                new Sala { Id = 15, Nombre = "Sala 15" },
                new Sala { Id = 16, Nombre = "Sala 16" },
                new Sala { Id = 17, Nombre = "Sala 17" },
                new Sala { Id = 18, Nombre = "Sala 18" },
                new Sala { Id = 19, Nombre = "Sala 19" },
                new Sala { Id = 20, Nombre = "Sala 20" },
                new Sala { Id = 21, Nombre = "Sala 21" },
                new Sala { Id = 22, Nombre = "Sala 22" },
                new Sala { Id = 23, Nombre = "Sala 23" },
                new Sala { Id = 24, Nombre = "Sala 24" },
                new Sala { Id = 25, Nombre = "Sala 25" },
                new Sala { Id = 26, Nombre = "Sala 26" },
                new Sala { Id = 27, Nombre = "Sala 27" },
                new Sala { Id = 28, Nombre = "Sala 28" },
                new Sala { Id = 29, Nombre = "Sala 29" },
                new Sala { Id = 30, Nombre = "Sala 30" },
                new Sala { Id = 31, Nombre = "Sala 31" },
                new Sala { Id = 32, Nombre = "Sala 32" },
                new Sala { Id = 33, Nombre = "Sala de Computacion" },
                new Sala { Id = 34, Nombre = "Inspectoría" },
                new Sala { Id = 35, Nombre = "Oficina de UTP" },
                new Sala { Id = 36, Nombre = "Oficina PIE" }
            );

            modelBuilder.Entity<FallaComun>().HasData(
                new FallaComun { Id = 1, Equipo = "Proyector", Descripcion = "No da imagen / Pantalla azul" },
                new FallaComun { Id = 2, Equipo = "Proyector", Descripcion = "No enciende" },
                new FallaComun { Id = 3, Equipo = "PC", Descripcion = "No enciende / No da video" },
                new FallaComun { Id = 4, Equipo = "PC", Descripcion = "No tiene internet" },
                new FallaComun { Id = 5, Equipo = "Mouse/Teclado", Descripcion = "No responde el cursor o teclas" },
                new FallaComun { Id = 6, Equipo = "Parlantes", Descripcion = "No se escucha el audio" }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SoporteColegio.Data;

var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrWhiteSpace(port))
{
    builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
}
else
{
    builder.WebHost.UseUrls("http://0.0.0.0:5000");
}

var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
if (!string.IsNullOrWhiteSpace(databaseUrl))
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(databaseUrl));
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite("Data Source=soporte.db"));
}

builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var db = scope.ServiceProvider.GetRequiredService<SoporteColegio.Data.ApplicationDbContext>();
	db.Database.EnsureCreated();
}

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Profesor}/{action=Index}/{id?}");
app.MapHub<SoporteColegio.Hubs.SoporteHub>("/soporteHub");

app.Run();

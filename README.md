# SoporteColegio

Aplicación web ASP.NET Core para gestión de tickets y soporte de salas dentro del colegio.

## Tecnologías

- .NET 9 SDK
- ASP.NET Core MVC
- EF Core + SQLite
- SignalR
- Python 3.x (se incluye una demo simple del patrón MVC)

## Estructura principal

- `Program.cs`: arranque de la aplicación
- `Data/`: contexto de base de datos
- `controllers/`: controladores MVC
- `models/`: entidades del dominio
- `ViewModels/`: modelos para las vistas
- `views/`: vistas Razor
- `Hubs/`: SignalR hub
- `Migrations/`: migraciones de EF Core

## Requisitos

1. Instalar .NET 9 SDK
2. Tener Python 3 instalado si quieres ejecutar la demo de Python

## Ejecutar la app web principal

```powershell
cd "c:\Users\MAURICIO\Desktop\proyecto_salas"
dotnet restore
dotnet run --urls http://localhost:5000
```

Luego abre:

```text
http://localhost:5000
```

## Ejecutar la demo Python

```powershell
cd "c:\Users\MAURICIO\Desktop\proyecto_salas"
py main.py
```

## Dependencias

El proyecto .NET usa EF Core y SQLite, y se restauran con:

```powershell
dotnet restore
```

El archivo `requirements.txt` no tiene paquetes adicionales para la demo de Python, por lo que basta con tener Python instalado.

## Nota importante

El README anterior estaba desactualizado y describía un proyecto Python puro, pero la aplicación funcional del repositorio es la versión .NET de ASP.NET Core.

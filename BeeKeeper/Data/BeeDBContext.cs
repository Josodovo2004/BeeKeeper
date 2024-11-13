using BeeKeeper.Models;
using Microsoft.EntityFrameworkCore;

public class BeeDbContext : DbContext
{
    public DbSet<Especie> Especies { get; set; }
    public DbSet<Panal> Panales { get; set; }
    public DbSet<Enfermedad> Enfermedades { get; set; }
    public DbSet<Medicamento> Medicamentos { get; set; }
    public DbSet<Tratamiento> Tratamientos { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<PanalEvento> PanalEventos { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ProductoPanal> ProductoPanals { get; set; }
    public DbSet<Cosecha> Cosechas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Panal>()
            .HasKey(p => new { p.IdPanal, p.IdEspecie });

        modelBuilder.Entity<Tratamiento>()
            .HasKey(t => new { t.IdPanal, t.IdEspecie, t.IdEnfermedad, t.IdMedicamento });

        modelBuilder.Entity<PanalEvento>()
            .HasKey(pe => new { pe.IdPanal, pe.IdEspecie, pe.IdEvento });

        modelBuilder.Entity<ProductoPanal>()
            .HasKey(pp => new { pp.IdProductoPanel, pp.IdEspecie, pp.IdProducto });

        modelBuilder.Entity<Cosecha>()
            .HasKey(c => new { c.IdCosecha, c.IdProductoPanal });

        // Define relationships if needed (not strictly necessary if EF Core can infer them)
    }
}

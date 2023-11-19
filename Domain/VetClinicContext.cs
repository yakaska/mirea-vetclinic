using Microsoft.EntityFrameworkCore;
using mirea_vetclinic.Domain.Models;

namespace mirea_vetclinic.Domain;

public class VetClinicContext : DbContext
{
    public DbSet<Visit> Visits { get; set; } = null!;
    public DbSet<Hostess> Hostesses { get; set; } = null!;
    public DbSet<Owner> Owners { get; set; } = null!;
    public DbSet<Pet> Pets { get; set; } = null!;
    public DbSet<Procedure> Procedures { get; set; } = null!;
    public DbSet<Specialty> Specialties { get; set; } = null!;
    public DbSet<Specie> Species { get; set; } = null!;
    public DbSet<Vet> Vets { get; set; } = null!;

    public VetClinicContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VetSpecialties>().HasKey(vs => new { vs.VetId, vs.SpecialtyId });
        modelBuilder.Entity<VisitProcedures>().HasKey(vp => new { vp.VisitId, vp.ProcedureId });
    }
}
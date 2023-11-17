using Microsoft.EntityFrameworkCore;
using mirea_vetclinic.Domain.Models;

namespace mirea_vetclinic.Domain;

public class VetClinicContext : DbContext
{
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Hostess> Hostesses { get; set; }
    public DbSet<Owner?> Owners { get; set; }
    public DbSet<Pet?> Pets { get; set; }
    public DbSet<Procedure> Procedures { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Specie> Species { get; set; }
    public DbSet<Vet> Vets { get; set; }

    public VetClinicContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VetSpecialties>().HasKey(vs => new { vs.VetId, vs.SpecialtyId });
        modelBuilder.Entity<VisitProcedures>().HasKey(vp => new { vp.VisitId, vp.ProcedureId });
        modelBuilder.Entity<PetSpecie>().HasKey(ps => new { ps.PetId, ps.SpecieId });
    }
}
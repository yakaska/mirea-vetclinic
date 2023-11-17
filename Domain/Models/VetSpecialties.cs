namespace mirea_vetclinic.Domain.Models;

public class VetSpecialties
{
    public int VetId { get; set; }
    public Vet Vet { get; set; }
    
    public int SpecialtyId { get; set; }
    public Specialty Specialty { get; set; }
}
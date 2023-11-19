namespace mirea_vetclinic.Domain.Models;

public class Specialty
{
    public int Id { get; set; }
    public string SpecialtyName { get; set; }

    public IList<Vet> Vets { get; set; }
    
} 
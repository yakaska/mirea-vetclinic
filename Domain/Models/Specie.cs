namespace mirea_vetclinic.Domain.Models;

public class Specie
{
    public int Id { get; set; }
    public string SpecieName { get; set; }

    public ICollection<Pet> Pets { get; set; }
}
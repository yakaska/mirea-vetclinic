namespace mirea_vetclinic.Domain.Models;

public class PetSpecie
{
    public int PetId { get; set; }
    public Pet Pet { get; set; }

    public int SpecieId { get; set; }
    public Specie Specie { get; set; }
}
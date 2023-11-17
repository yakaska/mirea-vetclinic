namespace mirea_vetclinic.Domain.Models;

public class Pet
{
    public int Id { get; set; }
    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Status { get; set; }
    public string Description { get; set; }
    public int OwnerId { get; set; }
    public int SpecieId { get; set; }

    public Owner Owner { get; set; }
    public Specie Specie { get; set; }
    public IList<Visit> Appointments { get; set; }
}
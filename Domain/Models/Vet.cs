namespace mirea_vetclinic.Domain.Models;

public class Vet
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public string PhoneNumber { get; set; }
    
    public IList<Visit> Visits { get; set; }

    public IList<Specialty> Specialties { get; set; }
}
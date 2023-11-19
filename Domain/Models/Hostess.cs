namespace mirea_vetclinic.Domain.Models;

public class Hostess
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public string PhoneNumber { get; set; }

    public IList<Visit> Appointments { get; set; }
}
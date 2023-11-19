namespace mirea_vetclinic.Domain.Models;

public class Owner
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronymic { get; set; }
    public string? Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public virtual List<Pet> Pets { get; set; }
}
namespace mirea_vetclinic.Domain.Models;

public class Visit
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    
    public IList<Procedure> Procedures { get; set; }
}
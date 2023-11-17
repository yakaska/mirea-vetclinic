namespace mirea_vetclinic.Domain.Models;

public class Visit
{
    public int Id { get; set; }
    public int VetId { get; set; }
    public int PetId { get; set; }
    public int HostessId { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DateTime Date { get; set; }

    public Vet Vet { get; set; }
    public Pet Pet { get; set; }
    public Hostess Hostess { get; set; }
    
    public IList<VisitProcedures> VisitProcedures { get; set; }
}
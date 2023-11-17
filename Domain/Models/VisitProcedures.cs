namespace mirea_vetclinic.Domain.Models;

public class VisitProcedures
{
    public int VisitId { get; set; }
    public Visit Visit { get; set; }
    
    public int ProcedureId { get; set; }
    public Procedure Procedure { get; set; }
}
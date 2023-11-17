namespace mirea_vetclinic.Domain.Models;

public class Procedure
{
    public int Id { get; set; }
    public string ProcedureName { get; set; }

    public IList<VisitProcedures> VisitProcedures { get; set; }
}
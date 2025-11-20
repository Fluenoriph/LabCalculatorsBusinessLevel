namespace LabCalculatorsBusinessLevel.Models;


public partial class Register
{
    public int Id { get; set; }

    public int Calctypeid { get; set; }

    public int Calcdateid { get; set; }

    public int Parametersid { get; set; }

    public int Resultsid { get; set; }

    public virtual Dateofcalculation Calcdate { get; set; } = null!;

    public virtual Typeofcalculator Calctype { get; set; } = null!;

    public virtual Airparameters Parameters { get; set; } = null!;

    public virtual Airresults Results { get; set; } = null!;
}

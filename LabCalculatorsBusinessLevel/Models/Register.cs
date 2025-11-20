namespace LabCalculatorsBusinessLevel.Models;


public partial class Register
{
    public int Id { get; set; }

    public int CalcTypeId { get; set; }

    public int CalcDateId { get; set; }

    public int ParametersId { get; set; }

    public int ResultsId { get; set; }

    public DateOfCalculation CalcDate { get; set; } = null!;

    public TypeOfCalculator CalcType { get; set; } = null!;

    public AirParameters Parameters { get; set; } = null!;

    public AirResults Results { get; set; } = null!;
}

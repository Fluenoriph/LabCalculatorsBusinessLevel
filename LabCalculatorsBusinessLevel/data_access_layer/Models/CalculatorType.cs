namespace LabCalculatorsBusinessLevel.Models;


public partial class CalculatorType
{
    public int CalcTypeId { get; set; }

    public string CalcTypeName { get; set; } = null!;

    public virtual ICollection<RegistrationTime> RegistrationTime { get; set; } = [];
}

namespace LabCalculatorsBusinessLevel.Models;


public partial class FormulaTypeCalculatorData
{
    public int DataId { get; set; }

    public List<float>? Parameter { get; set; }

    public List<float>? Result { get; set; }

    public int RegTimeId { get; set; }

    public virtual RegistrationTime RegTime { get; set; } = null!;
}

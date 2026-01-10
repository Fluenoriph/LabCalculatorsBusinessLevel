

partial class FormulaTypeCalculatorData
{
    public int DataId { get; set; }

    public List<double>? Parameter { get; set; }

    public List<double>? Result { get; set; }

    public int RegTimeId { get; set; }

    public virtual RegistrationTime RegTime { get; set; } = null!;
}

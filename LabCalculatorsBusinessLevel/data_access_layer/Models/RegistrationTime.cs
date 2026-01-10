

partial class RegistrationTime
{
    public int RegTimeId { get; set; }

    public DateTime? RegTimeValue { get; set; }

    public int CalcTypeId { get; set; }

    public virtual CalculatorType CalcType { get; set; } = null!;

    public virtual ICollection<FormulaTypeCalculatorData> FormulaTypeCalculatorData { get; set; } = [];

    public virtual ICollection<NoiseCalculatorData> NoiseCalculatorData { get; set; } = [];
}

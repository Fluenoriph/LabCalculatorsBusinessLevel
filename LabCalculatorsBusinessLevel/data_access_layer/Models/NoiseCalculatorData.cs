

partial class NoiseCalculatorData
{
    public int DataId { get; set; }

    public List<double>? SourceLevel { get; set; }

    public List<double>? BackgroundLevel { get; set; }

    public List<double>? Delta { get; set; }

    public List<double>? Result { get; set; }

    public int RegTimeId { get; set; }

    public virtual RegistrationTime RegTime { get; set; } = null!;
}

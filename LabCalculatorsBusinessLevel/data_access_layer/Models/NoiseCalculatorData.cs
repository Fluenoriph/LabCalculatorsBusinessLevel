

partial class NoiseCalculatorData
{
    public int DataId { get; set; }

    public List<float>? SourceLevel { get; set; }

    public List<float>? BackgroundLevel { get; set; }

    public List<float>? Delta { get; set; }

    public List<float>? Result { get; set; }

    public int RegTimeId { get; set; }

    public virtual RegistrationTime RegTime { get; set; } = null!;
}

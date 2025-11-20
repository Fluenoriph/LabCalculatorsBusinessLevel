namespace LabCalculatorsBusinessLevel.Models;


public partial class AirParameters
{
    public int Id { get; set; }

    public float Volume { get; set; }

    public float Temperature { get; set; }

    public float Pressure { get; set; }

    public float FilterWeightBefore { get; set; }

    public float FilterWeightAfter { get; set; }

    public ICollection<Register> Registers { get; set; } = [];
}

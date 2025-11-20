namespace LabCalculatorsBusinessLevel.Models;


public partial class AirResults
{
    public int Id { get; set; }

    public float Concentrate { get; set; }

    public float Fault { get; set; }

    public ICollection<Register> Registers { get; set; } = [];
}

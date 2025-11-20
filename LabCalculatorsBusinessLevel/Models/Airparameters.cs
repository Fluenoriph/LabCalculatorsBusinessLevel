namespace LabCalculatorsBusinessLevel.Models;


public partial class Airparameters
{
    public int Id { get; set; }

    public float Volume { get; set; }

    public float Temperature { get; set; }

    public float Pressure { get; set; }

    public float Massbefore { get; set; }

    public float Massafter { get; set; }

    public virtual ICollection<Register> Registers { get; set; } = [];
}

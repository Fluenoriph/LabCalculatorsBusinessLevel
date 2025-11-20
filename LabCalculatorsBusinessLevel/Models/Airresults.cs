namespace LabCalculatorsBusinessLevel.Models;


public partial class Airresults
{
    public int Id { get; set; }

    public float Concentrate { get; set; }

    public float Fault { get; set; }

    public virtual ICollection<Register> Registers { get; set; } = [];
}

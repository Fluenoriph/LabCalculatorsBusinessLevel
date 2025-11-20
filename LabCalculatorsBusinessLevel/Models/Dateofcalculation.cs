namespace LabCalculatorsBusinessLevel.Models;


public partial class Dateofcalculation
{
    public int Id { get; set; }

    public DateTime Value { get; set; }

    public virtual ICollection<Register> Registers { get; set; } = new List<Register>();
}

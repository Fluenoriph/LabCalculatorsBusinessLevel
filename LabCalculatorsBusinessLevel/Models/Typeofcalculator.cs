namespace LabCalculatorsBusinessLevel.Models;


public partial class TypeOfCalculator
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Register> Registers { get; set; } = [];
}

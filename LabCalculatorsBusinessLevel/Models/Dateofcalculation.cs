namespace LabCalculatorsBusinessLevel.Models;


public partial class DateOfCalculation
{
    public int Id { get; set; }

    public DateTime Value { get; set; }

    public ICollection<Register> Registers { get; set; } = [];
}

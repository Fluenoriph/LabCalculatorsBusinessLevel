using System;
using System.Collections.Generic;

namespace LabCalculatorsBusinessLevel.Models;

public partial class Dateofcalculation
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public virtual ICollection<Register> Registers { get; set; } = new List<Register>();
}

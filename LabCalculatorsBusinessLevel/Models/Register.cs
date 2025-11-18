using System;
using System.Collections.Generic;

namespace LabCalculatorsBusinessLevel.Models;

public partial class Register
{
    public int Id { get; set; }

    public int Calctype { get; set; }

    public int Calcdate { get; set; }

    public virtual Dateofcalculation CalcdateNavigation { get; set; } = null!;

    public virtual Typeofcalculator CalctypeNavigation { get; set; } = null!;
}

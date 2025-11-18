using System;
using System.Collections.Generic;

namespace LabCalculatorsBusinessLevel.Models;

public partial class Airparameter
{
    public int Parametersid { get; set; }

    public float Volume { get; set; }

    public float Temperature { get; set; }

    public float Pressure { get; set; }

    public float Massbefore { get; set; }

    public float Massafter { get; set; }

    public int Registerid { get; set; }

    public virtual Register Register { get; set; } = null!;
}

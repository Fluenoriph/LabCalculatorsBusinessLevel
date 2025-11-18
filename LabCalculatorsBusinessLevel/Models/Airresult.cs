using System;
using System.Collections.Generic;

namespace LabCalculatorsBusinessLevel.Models;

public partial class Airresult
{
    public int Resultsid { get; set; }

    public float Concentrate { get; set; }

    public float Fault { get; set; }

    public int Registerid { get; set; }

    public virtual Register Register { get; set; } = null!;
}

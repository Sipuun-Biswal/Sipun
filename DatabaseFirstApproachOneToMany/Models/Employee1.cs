using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachOneToMany.Models;

public partial class Employee1
{
    public int Slno { get; set; }

    public string? Name { get; set; }

    public string? Domain { get; set; }

    public int? Age { get; set; }
}

using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachOneToMany.Models;

public partial class Credentialss
{
    public int Id { get; set; }

    public string? Names { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? Passwords { get; set; }
}

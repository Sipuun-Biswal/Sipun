using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachOneToMany.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public decimal? Salary { get; set; }

    public string? Department { get; set; }
}

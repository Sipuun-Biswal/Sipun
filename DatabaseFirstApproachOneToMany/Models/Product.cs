using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachOneToMany.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}

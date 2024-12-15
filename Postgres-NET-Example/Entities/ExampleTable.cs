using System;
using System.Collections.Generic;

namespace Entities;

public partial class ExampleTable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}

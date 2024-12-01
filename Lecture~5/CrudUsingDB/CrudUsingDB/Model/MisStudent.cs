using System;
using System.Collections.Generic;

namespace CrudUsingDB.Model;

public partial class MisStudent
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Age { get; set; }

    public string? Address { get; set; }
}

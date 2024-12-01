using System;
using System.Collections.Generic;

namespace CrudUsingDB.Model;

public partial class MisCourseDetail
{
    public int? Id { get; set; }

    public int? StudentId { get; set; }

    public string? CourseName { get; set; }
}

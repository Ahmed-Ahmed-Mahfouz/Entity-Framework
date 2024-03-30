using System;
using System.Collections.Generic;

namespace EntityFramworkLab1.Models;

public partial class StudentCourseView
{
    public string StudentFullName { get; set; } = null!;

    public string? CourseName { get; set; }
}

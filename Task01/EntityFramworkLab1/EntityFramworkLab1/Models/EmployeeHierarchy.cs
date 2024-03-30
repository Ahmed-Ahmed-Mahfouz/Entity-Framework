using System;
using System.Collections.Generic;

namespace EntityFramworkLab1.Models;

public partial class EmployeeHierarchy
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public int? ManagerId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EntityFramworkLab1.Models;

public partial class StudentAudit
{
    public int AuditId { get; set; }

    public string? UserName { get; set; }

    public DateTime? Date { get; set; }

    public string? Note { get; set; }
}

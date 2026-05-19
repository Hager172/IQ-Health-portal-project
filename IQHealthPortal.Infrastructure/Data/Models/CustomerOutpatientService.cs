using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CustomerOutpatientService
{
    public int Id { get; set; }

    public string? Outpatientexamination { get; set; }

    public bool? Labs { get; set; }

    public bool? Radiology { get; set; }

    public bool? Physiotherapy { get; set; }

    public string? OutpatientPrescribedMedication { get; set; }

    public string? Program { get; set; }

    public DateTime? Date { get; set; }
}

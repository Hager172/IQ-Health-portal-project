using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs
{
    public class DiagnosisDto
    {
        public string Id { get; set; } = null!;

        public string? Name { get; set; }
        public string? onlineName { get; set; }

        public int Category { get; set; }

        public int CareItem { get; set; }

        public int? Type { get; set; }
    }
}

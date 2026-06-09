using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ClaimDto
    {
        public string MembId { get; set; }

        public DateTime ServiceDate { get; set; }

        public string PresId { get; set; }

        public string? Phone { get; set; }

        public string? DiagnosisString { get; set; }

        public string? DiagnosisInsString { get; set; }

        public string? Notes { get; set; }

        public List<ClaimServiceDto> Services { get; set; }

        // OUTPUT
        public string? Contract { get; set; }

        public string? MsgHolder { get; set; }

        public float Coinsurance { get; set; }

        public float MaxValue { get; set; }

        public long ApprovalCode { get; set; }
    }
}

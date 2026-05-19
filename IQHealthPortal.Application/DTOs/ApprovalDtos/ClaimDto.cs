using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ClaimDto
    {
        public string MembId { get; set; }

        public DateTime ServiceDate { get; set; }

        public int[] Product { get; set; }

        public string PresId { get; set; }

        public string? Phone { get; set; }

        public string? DiagnosisString { get; set; }

        public string? DiagnosisInsString { get; set; }

        public string? Notes { get; set; }

        // SERVICES DATA
        public float Qty { get; set; }

        public float[] Price { get; set; }

        public int[] Units { get; set; }

        public int[] Rep { get; set; }

        public int[] Duration { get; set; }

        // OUTPUT / GENERATED DATA
        public string? Contract { get; set; }

        public string? MsgHolder { get; set; }

        public float Coinsurance { get; set; }

        public float MaxValue { get; set; }

        public long ApprovalCode { get; set; }
    }
}

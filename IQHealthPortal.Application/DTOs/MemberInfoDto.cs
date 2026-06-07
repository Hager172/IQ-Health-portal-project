using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs
{
    public class MemberInfoDto
    {
        public string MemberId { get; set; }

        public string MemberName { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }
        public string MemberStatus { get; set; }
        public string CustomerStatus { get; set; }
        public string CardImageUrl { get; set; }
        public decimal Coinsurance { get; set; }
        public string ParentName { get; set; }
        public string? BirthDate { get; set; }
        public string ExpirationMessage { get; set; }
        public string ChronicApproval { get; set; }
        public string BalanceWarning { get; set; }
        public string? MemberNationalId { get; set; }

    }
}

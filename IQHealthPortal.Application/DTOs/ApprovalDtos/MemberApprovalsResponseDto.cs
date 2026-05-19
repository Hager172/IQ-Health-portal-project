using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class MemberApprovalsResponseDto
    {
        public string MemberId { get; set; } = null!;
        public List<MemberApprovalListDto> Approvals { get; set; }
            = new List<MemberApprovalListDto>();

    }
}

using IQHealthPortal.Application.DTOs.itemsDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class ClaimResultDto
    {
        public string ClaimId { get; set; }

        public string PresId { get; set; }

        public string Result { get; set; }

        public List<OnlineServiceItemDto> Items { get; set; } = new();
    }
}

using System.Collections.Generic;

namespace IQHealthPortal.Application.DTOs.ApprovalDtos
{
    public class UpdateClaimsRequestDto
    {
        public string ApprovalId { get; set; } = null!;

        public string? Notes { get; set; }

        public bool IsChronic { get; set; }

        public List<UpdateClaimItemDto> Items { get; set; } = new();
    }

    public class UpdateClaimItemDto
    {
        public int ItemSerial { get; set; }

        // The approved quantity (the Java "approved" array). Sent to UpdateClaims.
        public int Qty { get; set; }

        // The originally claimed quantity (the Java "claim" array). Used only for
        // validation: an approved qty may never exceed the claimed qty.
        public int Claimed { get; set; }

        public string? Days { get; set; }

        public string? Description { get; set; }
    }
}

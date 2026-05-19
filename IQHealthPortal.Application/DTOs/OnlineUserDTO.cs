using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.DTOs
{
    public class OnlineUserDTO
    {
        public long Id { get; set; }

        public string UserName { get; set; } = null!;

        public string? Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public short? Status { get; set; }

        public DateOnly? BirthOfDate { get; set; }

        public DateOnly? CreationDate { get; set; }

        public string? Email { get; set; }

        public string? Mobile { get; set; }

        public int? RoleId { get; set; }

        public string? Vendor { get; set; }

        public string? VType { get; set; }
        public string? Office { get; set; }
    }
}

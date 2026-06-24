using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IQHealthPortal.Domain.Identity.Entities
{
    public class OnlineUsers
    {
        [Key]
        public string Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public short? Status { get; set; }

        public DateTime? BirthOfDate { get; set; }
        public DateTime? CreationDate { get; set; }

        public string Email { get; set; }
        public string Mobile { get; set; }

        public string Lang { get; set; }
        public string Theme { get; set; }

        public string CountryId { get; set; }
        public string Address { get; set; }

        public string Position { get; set; }
        public string Office { get; set; }

        public DateTime? JoiningDate { get; set; }

        public decimal? Salary { get; set; }

        public long? ProfilePicDocumentId { get; set; }

        public string RoleId { get; set; }

        public string Vendor { get; set; }
        public string V_Type { get; set; }

        public string UserId { get; set; }

        public int? ClientId { get; set; }


        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
        public OnlineClient Client { get; set; }
    }
}

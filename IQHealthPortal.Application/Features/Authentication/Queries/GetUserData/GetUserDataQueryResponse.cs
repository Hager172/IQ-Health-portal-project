using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using IQHealthPortal.Application.DTOs;

namespace IQHealthPortal.Infrastructure.UserService.Queries.GetUserData
{
    public class GetUserDataQueryResponse
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Pic { get; set; } = "./assets/media/avatars/blank.png";
        public List<string> Roles { get; set; } = new List<string>();
        public string Occupation { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public AddressModel Address { get; set; }
        public SocialNetworksModel SocialNetworks { get; set; }

        // Personal Information
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Website { get; set; }

        // Account Information
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public CommunicationModel Communication { get; set; }

        // Email Settings
        public EmailSettingsModel EmailSettings { get; set; }

        public List<PageDto> Pages { get; set; } = new List<PageDto>();

        public String CurrentClinetId { get; set; }
        public List<OnlineUserClientDto> clients { get; set; }


    }

    public class OnlineUserClientDto
    {

        public int ClientId { get; set; }
        public string ClientName { get; set; }

        
    }
    public class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class SocialNetworksModel
    {
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
    }

    public class CommunicationModel
    {
        public bool Email { get; set; }
        public bool Sms { get; set; }
        public bool Phone { get; set; }
    }

    public class EmailSettingsModel
    {
        public bool EmailNotification { get; set; }
        public bool SendCopyToPersonalEmail { get; set; }
        public ActivityRelatedEmailModel ActivityRelatesEmail { get; set; }
        public UpdatesFromKeenthemesModel UpdatesFromKeenthemes { get; set; }
    }

    public class ActivityRelatedEmailModel
    {
        public bool YouHaveNewNotifications { get; set; }
        public bool YouAreSentADirectMessage { get; set; }
        public bool SomeoneAddsYouAsAConnection { get; set; }
        public bool UponNewOrder { get; set; }
        public bool NewMembershipApproval { get; set; }
        public bool MemberRegistration { get; set; }
    }

    public class UpdatesFromKeenthemesModel
    {
        public bool NewsAboutKeenthemesProductsAndFeatureUpdates { get; set; }
        public bool TipsOnGettingMoreOutOfKeen { get; set; }
        public bool ThingsYouMissedSinceYouLastLoggedIntoKeen { get; set; }
        public bool NewsAboutMetronicOnPartnerProductsAndOtherServices { get; set; }
        public bool TipsOnMetronicBusinessProducts { get; set; }
    }
    public class Pagedto
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? PageParentId { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string Route { get; set; }
        [JsonIgnore]
        public Pagedto ParentPage { get; set; }
        public ICollection<Pagedto> SubPages { get; set; } = new List<Pagedto>();
    }
}

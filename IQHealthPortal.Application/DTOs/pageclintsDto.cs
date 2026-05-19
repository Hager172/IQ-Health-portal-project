using IQHealthPortal.Domain.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace IQHealthPortal.Application.DTOs
{
    internal class pageclintsDto
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
        public pageclintsDto ParentPage { get; set; }
        public ICollection<pageclintsDto> SubPages { get; set; } = new List<pageclintsDto>();
    }
}

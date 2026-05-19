using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class WebCommonDisease
{
    public int DiseaseId { get; set; }

    public string ArabicName { get; set; } = null!;

    public string EnglishName { get; set; } = null!;

    public virtual ICollection<WebCustomerRequest> Serials { get; set; } = new List<WebCustomerRequest>();
}

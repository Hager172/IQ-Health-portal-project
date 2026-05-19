using System;
using System.Collections.Generic;

namespace IQHealthPortal.Infrastructure.Data.Models;

public partial class CrmContractExcutor
{
    public int ContractId { get; set; }

    public string ExcutorId { get; set; } = null!;

    public bool IsMain { get; set; }

    public DateTime CreationDate { get; set; }

    public int Status { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public string LastUpdateFrom { get; set; } = null!;

    public virtual CrmCustomerContract Contract { get; set; } = null!;

    public virtual AspNetUser Excutor { get; set; } = null!;

    public virtual StatusProcedure StatusNavigation { get; set; } = null!;
}

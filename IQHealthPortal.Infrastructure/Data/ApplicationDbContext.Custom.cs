using System;
using Microsoft.EntityFrameworkCore;

namespace IQHealthPortal.Infrastructure.Data;

// Manual additions to the scaffolded ApplicationDbContext.
// Kept in a separate partial file so they survive `Scaffold-DbContext ... -Force`,
// which only regenerates ApplicationDbContext.cs.
public partial class ApplicationDbContext
{
    // Maps to the SQL scalar function dbo.f_member_status_at_date(@memberId, @date).
    // Called in LINQ (see MemberRepository.GetMemberStatusAsync); EF translates it to SQL,
    // so the body is never executed in-process.
    [DbFunction("f_member_status_at_date", "dbo")]
    public static string MemberStatusAtDate(string memberId, DateTime date)
    {
        throw new NotImplementedException();
    }
}

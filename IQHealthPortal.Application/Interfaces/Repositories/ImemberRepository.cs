using IQHealthPortal.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface ImemberRepository
    {
        //Task UpdateMemberPhoneAsync(Member member);

        Task UpdateMemberPhoneAsync(
        string memberId,
        string phone);

        Task<string?> GetMemberStatusAsync(string memberId);


        Task<MemberDto?> GetMemberById(string id);
        Task<string?> GetActiveContractAsync(string memberId);

        Task<int> GetGracePeriodAsync(string item);

        Task<string> GetApprovalStatusAsync(string formId, string formIdZero);
    }
}

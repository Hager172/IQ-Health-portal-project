using IQHealthPortal.Application.DTOs;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Infrastructure.Data;
using IQHealthPortal.Infrastructure.Data.Models;
using IQHealthPortal.Infrastructure.Identity.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{
    public class MemberRepository : ImemberRepository
    {
        //private readonly UnitOfWork unitOfWork;
        private readonly IConnectionStringProvider connectionStringProvider;

        public MemberRepository(IConnectionStringProvider connectionStringProvider) {

            this.connectionStringProvider = connectionStringProvider;

        }


        public ApplicationDbContext CreateContext()
        {
            var connection =
                connectionStringProvider.GetCurrentConnectionString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connection)
                .Options;

            return new ApplicationDbContext(options);
        }
        public async Task UpdateMemberPhoneAsync(string memberId, string phone)
        {
            using var context = CreateContext();

            var member = await context.Members
                .FirstOrDefaultAsync(x => x.MemberId == memberId);

            if (member == null)
                return;

            if (string.IsNullOrEmpty(member.MemberTele) || member.MemberTele.Length < 11)
            {
                member.MemberTele = phone;
                await context.SaveChangesAsync();
            }
        }
        public async Task<string?> GetMemberStatusAsync(string memberId)
        {
            using var context = CreateContext();

            var result = await context.Members
                .Where(m => m.MemberId == memberId)
                .Select(m => ApplicationDbContext.MemberStatusAtDate(
                    m.MemberId,
                    DateTime.Now))
                .FirstOrDefaultAsync();

            return result;
        }


        public async Task<string?> GetActiveContractAsync(string memberId)
        {
            using var context = CreateContext();

            var contract = await (
                from mp in context.MemberPlans
                join cp in context.ContractPlans
                    on mp.PlanCode equals cp.ContractPlanId
                join cc in context.CustomerContracts
                    on cp.ContractId equals cc.CustomerContractId
                where mp.MemberCode == memberId
                      && DateTime.Now >= cc.CustomerContractStartDate
                      && DateTime.Now <= cc.CustomerContractEndDate
                select cp.ContractId
            ).FirstOrDefaultAsync();

            return contract;
        }


        public async Task<string> GetApprovalStatusAsync(string formId, string formIdZero)
        {
            using var context = CreateContext();

            return await context.Approvals
                .Where(a => a.OnlineStatus != "D" &&
                       (a.FormId == formId || a.FormId == formIdZero))
                .Select(a => a.OnlineStatus)
                .FirstOrDefaultAsync()
                ?? "1";
        }





        public async Task<MemberDto?> GetMemberById(string id)
        {
            using var context = CreateContext();

            return await context.Members
                .Where(x => x.MemberId == id)
                .Select(x => new MemberDto
                {
                    MemberId = x.MemberId,
                    MemberTele = x.MemberTele,
                    MemberName = x.MemberName
                })
                .FirstOrDefaultAsync();
        }

        public async Task<int> GetGracePeriodAsync(string item)
        {
            using var context = CreateContext();

            var value = await context.OnlineSettings
                .Where(s => s.Item == item)
                .Select(s => s.Value)
                .FirstOrDefaultAsync();

            return value ?? 0;
        }
    }
}

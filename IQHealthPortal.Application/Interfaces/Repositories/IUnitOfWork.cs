using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;

public interface IUnitOfWork : IDisposable
{
    IPageRepository PageRepository { get; set; }

    IApprovalRepository ApprovalRepository { get; set; }

    IVendorRepository VendorRepository { get; set; }

    ImemberRepository memberrepository { get; set; }

    IClaimRepository ClaimRepository { get; set; }

    IRepository<T> ApplicationRepository<T>() where T : class;

    IRepository<T> IdentityRepository<T>() where T : class;

    IRepository<OnlineClient> OnlineClientRepository { get; set; }

    IRepository<OnlineUserClient> OnlineUserClientRepository { get; set; }

    IRepository<Privilege> PrivilegesRepository { get; set; }

    Task BeginTransactionAsync();

    Task CommitAsync();

    Task RollbackAsync();

    void SetConnectionString(string clientId);

    string getConnectionStringByClinetId(string clientId);

    string GetDefaultConnectionString();

    string getCurrentConnectionString();

    int Save();
}
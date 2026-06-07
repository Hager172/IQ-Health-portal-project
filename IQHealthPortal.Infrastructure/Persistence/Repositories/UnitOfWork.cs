using ACMS_ONLINE_INFRASTRUCTURE.Data;
using IQHealthPortal.Application.Interfaces.Repositories;
using IQHealthPortal.Domain.Identity.Entities;
using IQHealthPortal.Infrastructure.Data;
using IQHealthPortal.Infrastructure.Data.Models;
using IQHealthPortal.Infrastructure.Services.Identity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace IQHealthPortal.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory _dbContextFactory;
        private ApplicationDbContext _dbContext;
        private readonly IConnectionStringProvider _connectionStringProvider;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IdentityContext _dbIdentityContext;

        private IDbContextTransaction _transaction;
        //public IOnlineUserClientRepository OnlineUserClientRepository { get; set; }
        public IPageRepository PageRepository { get; set; }
        public IApprovalRepository ApprovalRepository { get; set; }
        public ImemberRepository memberrepository {  get; set; }

        public IClaimRepository ClaimRepository { get; set; }
        public IRepository<Privilege> PrivilegesRepository { get; set; }
        public IRepository<OnlineClient> OnlineClientRepository { get; set; }
        public IRepository<OnlineUserClient> OnlineUserClientRepository { get; set; }
        public IVendorRepository VendorRepository { get; set; }

        private readonly Dictionary<Type, object> _appRepositories = new();
        private readonly Dictionary<Type, object> _identityRepositories = new();

        public IRepository<T> ApplicationRepository<T>() where T : class
        {
            if (_appRepositories.ContainsKey(typeof(T)))
                return (IRepository<T>)_appRepositories[typeof(T)];

            var repo = new Repository<T>(_dbContext);
            _appRepositories[typeof(T)] = repo;
            return repo;
        }

        public IRepository<T> IdentityRepository<T>() where T : class
        {
            if (_identityRepositories.ContainsKey(typeof(T)))
                return (IRepository<T>)_identityRepositories[typeof(T)];

            var repo = new Repository<T>(_dbIdentityContext);
            _identityRepositories[typeof(T)] = repo;
            return repo;
        }


        public UnitOfWork(IDbContextFactory dbContextFactory, IdentityContext identityContext,
                          IConnectionStringProvider connectionStringProvider, IHttpContextAccessor contextAccessor, ImemberRepository memberrepository, IClaimRepository claimRepository)
        {
            _dbIdentityContext = identityContext;
            _dbContextFactory = dbContextFactory;
            _connectionStringProvider = connectionStringProvider;
            _contextAccessor = contextAccessor;
            this.memberrepository = memberrepository;
            // Initialize both contexts and repositories
            InitializeApplicationDbContext(GetDefaultConnectionString());
            InitializeIdentityDbContext();
            ClaimRepository = claimRepository;
        }

        // Initialize ApplicationDbContext and related repositories
        private void InitializeApplicationDbContext(string connectionString)
        {
            _dbContext = _dbContextFactory.CreateDbContext(connectionString);

           

        }

        // Initialize IdentityContext and related repositories
        private void InitializeIdentityDbContext()
        {
            
            PageRepository = new PageRepository(_dbIdentityContext);
            ApprovalRepository = new ApprovalRepository(_dbContext, _connectionStringProvider);
            VendorRepository = new VendorRepository(_dbContext);

            OnlineClientRepository = new Repository<OnlineClient>(_dbIdentityContext);
            OnlineUserClientRepository = new Repository<OnlineUserClient>(_dbIdentityContext);
            PrivilegesRepository = new Repository<Privilege>(_dbIdentityContext);
            
        }

        // Update connection string for ApplicationDbContext
        public void SetConnectionString(string clientId)
        {
            var connectionString = _connectionStringProvider.GetConnectionString(clientId);
            InitializeApplicationDbContext(connectionString);
           
        }




        public string GetDefaultConnectionString()
        {
            return _connectionStringProvider.GetDefaultConnectionString();
        }

        // Save changes for both contexts
        public int Save()
        {
            var appContextChanges = _dbContext.SaveChanges();
            var identityContextChanges = _dbIdentityContext.SaveChanges();
            return appContextChanges + identityContextChanges;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            _dbIdentityContext?.Dispose();
        }



        public string getCurrentConnectionString()
        {
            var clientId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "ClientId")?.Value;
            return getConnectionStringByClinetId(clientId);
        }
        public string getConnectionStringByClinetId(string clientId = "2")
        {
            return _connectionStringProvider.GetConnectionString(clientId);
        }
          public async Task BeginTransactionAsync()
    {
            _transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
            await _transaction.CommitAsync();
        }

        public async Task RollbackAsync()
    {
        await _transaction.RollbackAsync();
    }
    }
}

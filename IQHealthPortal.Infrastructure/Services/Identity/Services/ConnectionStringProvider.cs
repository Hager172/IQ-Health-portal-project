using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IQHealthPortal.Infrastructure.Services.Identity.Services
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private readonly IDictionary<string, string> _options;
        private readonly IHttpContextAccessor _contextAccessor;

        public ConnectionStringProvider(
            IOptions<ClientConnectionOptions> options,
            IHttpContextAccessor contextAccessor)
        {
            _options = options.Value;
            _contextAccessor = contextAccessor;
        }

        public string GetConnectionString(string clientId)
        {
            if (string.IsNullOrEmpty(clientId))
            {
                throw new ArgumentNullException(
                    nameof(clientId),
                    "Client ID cannot be null or empty.");
            }

            if (_options.ContainsKey(clientId))
            {
                return _options[clientId];
            }

            throw new ArgumentException(
                $"Connection string not found for client: {clientId}");
        }

        public string GetDefaultConnectionString()
        {
            return _options["1"];
        }

        public string GetCurrentConnectionString()
        {
            var clientId = _contextAccessor
                .HttpContext?
                .User?
                .Claims?
                .FirstOrDefault(x => x.Type == "ClientId")
                ?.Value;

            if (string.IsNullOrEmpty(clientId))
            {
                return GetDefaultConnectionString();
            }

            return GetConnectionString(clientId);
        }

        // Connection string for the remote replication server used by sendToLocal /
        // dbo.sp_manual_approvals_repl. Prefers a per-client key ("<clientId>_remote")
        // and falls back to a shared "remote" key under ConnectionStrings.
        public string GetRemoteConnectionString()
        {
            var clientId = _contextAccessor
                .HttpContext?
                .User?
                .Claims?
                .FirstOrDefault(x => x.Type == "ClientId")
                ?.Value;

            if (!string.IsNullOrEmpty(clientId) && _options.ContainsKey($"{clientId}_remote"))
            {
                return _options[$"{clientId}_remote"];
            }

            if (_options.ContainsKey("remote"))
            {
                return _options["remote"];
            }

            throw new InvalidOperationException(
                "No remote replication connection string configured " +
                "(expected key '<clientId>_remote' or 'remote' under ConnectionStrings).");
        }
    }
}
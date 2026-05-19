using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IQHealthPortal.Infrastructure.Identity.Services
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
    }
}
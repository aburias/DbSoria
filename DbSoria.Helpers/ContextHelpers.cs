using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace DbSoria.Helpers
{
    public class ContextHelpers : IContextHelpers
    {
        public string GetSubDomain(HttpContext httpContext, IConfiguration config)
        {
            var subDomain = string.Empty;

            var host = httpContext.Request.Host.Host;

            if (!string.IsNullOrWhiteSpace(host))
            {
                subDomain = host.Split('.')[0];
            }

            var env = config["Env"];
            var domain = config[$"SiteConfig:Domain:{env}"]?.Trim()?.ToLower();

            var storeDomain = subDomain?.Trim()?.ToLower();

            return storeDomain == domain || storeDomain == "localhost" ? string.Empty : storeDomain;
        }
    }
}
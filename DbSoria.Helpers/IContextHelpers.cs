using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace DbSoria.Helpers
{
    public interface IContextHelpers
    {
        public string GetSubDomain(HttpContext httpContext, IConfiguration config);
    }
}
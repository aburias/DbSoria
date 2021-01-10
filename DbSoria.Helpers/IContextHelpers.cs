using Microsoft.AspNetCore.Http;

namespace DbSoria.Helpers
{
    public interface IContextHelpers
    {
        public string GetSubDomain(HttpContext httpContext);
    }
}
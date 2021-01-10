using System.Collections.Generic;
using System.Threading.Tasks;
using DbSoria.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace DbSoria.Web.Filters
{
    public class SubDomainAsyncPageFilter : IAsyncPageFilter
    {
        private readonly IConfiguration _config;

        public SubDomainAsyncPageFilter(IConfiguration config)
        {
            _config = config;
        }

        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            var httpContext = context.HttpContext;

            var subDomain = string.Empty;

            var host = httpContext.Request.Host.Host;
            var isRootPath = string.IsNullOrEmpty(httpContext.Request.Path.Value?.Replace("/", ""));

            if (!string.IsNullOrWhiteSpace(host))
            {
                subDomain = host.Split('.')[0];
            }

            var env = _config["Env"];
            var domain = _config[$"SiteConfig:Domain:{env}"]?.Trim()?.ToLower();

            var storeDomain = subDomain?.Trim()?.ToLower();

            //if (storeDomain == "admin")
            //{
            //    context.Result = new RedirectToPageResult("Index", new {area = "Admin"});
            //}
            //else
            //    await next.Invoke();

            //httpContext.Items.Add(new KeyValuePair<object, object>("storeDomain", storeDomain));

            //if (httpContext.User.Identity.IsAuthenticated)
            //{

            //}

            //context.Result = storeDomain == domain || storeDomain == "localhost" ? Page() : storeDomain;

            await next.Invoke();
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return Task.CompletedTask;
        }
    }
}
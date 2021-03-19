using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbSoria.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace DbSoria.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IContextHelpers _contextHelpers;
        private readonly IConfiguration _config;

        public string SubDomain { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IContextHelpers contextHelpers, IConfiguration config)
        {
            _logger = logger;
            _contextHelpers = contextHelpers;
            _config = config;
        }

        public IActionResult OnGet()
        {
            // Use this later...
            var subdomain = HttpContext.Items["storeDomain"]?.ToString();
            //var subdomain = _contextHelpers.GetSubDomain(HttpContext, _config);

            //if (!string.IsNullOrEmpty(subdomain) && subdomain == "admin")
            //    return RedirectToPage("Index", new {area = "Admin"});

            //return !string.IsNullOrEmpty(subdomain) ? (IActionResult) RedirectToPage("Index", new {area = "Store"}) : Page();

            return Page();
        }
    }
}

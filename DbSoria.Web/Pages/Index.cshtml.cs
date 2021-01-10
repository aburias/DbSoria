using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbSoria.Helpers;
using Microsoft.AspNetCore.Http;

namespace DbSoria.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IContextHelpers _contextHelpers;

        public IndexModel(ILogger<IndexModel> logger, IContextHelpers contextHelpers)
        {
            _logger = logger;
            _contextHelpers = contextHelpers;
        }

        public IActionResult OnGet()
        {
            var subdomain = _contextHelpers.GetSubDomain(HttpContext);
            return Content(subdomain);
        }
    }
}

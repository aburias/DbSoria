using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace DbSoria.Web.Areas.Store.Pages
{
    public class IndexModel : PageModel
    {
        [Host("*.local-dbsoria.com")]
        public IActionResult OnGet()
        {
            return Content("Page");
        }
    }
}

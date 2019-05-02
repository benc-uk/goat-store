using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoatStore.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        public string ErrorMessage { get; set; }
        public string ErrorSource { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public void OnGet()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ErrorMessage = exceptionHandlerPathFeature.Error.Message;
            ErrorSource = exceptionHandlerPathFeature.Error.Source; 
        }
    }
}

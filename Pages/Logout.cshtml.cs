using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using CBBlazorEFID.Data;
using Microsoft.Extensions.Logging;

namespace CBBlazorEFID
{
    public class LogoutModel : PageModel
    {
        SignInManager<AppUser> signInManager;
        ILogger<LoginModel> logger;

        public LogoutModel(SignInManager<AppUser> signInManager, ILogger<LoginModel> logger)
        {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            await signInManager.SignOutAsync();
            logger.LogInformation("Logout");
            return Redirect("/");
        }
    }
}

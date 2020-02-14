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
    public class LoginModel : PageModel
    {
        SignInManager<AppUser> signInManager;
        ILogger<LoginModel> logger;

        public LoginModel(SignInManager<AppUser> signInManager, ILogger<LoginModel> logger)
        {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public async Task<IActionResult> OnGetAsync(string username, string password)
        {
            var result = await signInManager.PasswordSignInAsync(username, password, false, false);
            if (result.Succeeded) 
            {
                logger.LogInformation("Login success");
                return Redirect("/");
            }
            else 
            {
                logger.LogInformation("Login failed");
                return Redirect("/error");
            }
        }
    }
}

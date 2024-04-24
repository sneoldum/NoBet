using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging; // Import ILogger
using NoBet.Models;
using NoBet.Services;
using System.Collections.Generic;
using System.Linq;

namespace NoBet.Pages
{
    public class HomeModel : PageModel
    {
        private readonly ILogger<HomeModel> _logger;

        [BindProperty]
        public List<BetModel.Event> AllMatches { get; set; }

        [BindProperty]
        public Dictionary<int, MatchModel.Data> MatchDetails { get; set; } = new Dictionary<int, MatchModel.Data>();  // Instantiate MatchDetails

        public HomeModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPostLogoutRequest(UserService userService)
        {
            if (HttpContext.Request.Cookies.Count > 0)
            {
                var siteCookies = HttpContext.Request.Cookies.Where(c => c.Key.Contains(".AspNetCore.") || c.Key.Contains("Microsoft.Authentication") || c.Key.Contains("username"));
                foreach (var cookie in siteCookies)
                {
                    Response.Cookies.Delete(cookie.Key);
                }
            }
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");

        }

        [Authorize]
        public void OnGet()
        {
            var userName = Request.Cookies["username"];
            if (userName != null)
            {
                var betService = new BetService();
                var betData = betService.GetAllMatches();
                AllMatches = betData.Datas.events;
            }
        }

        public IActionResult Logout()
        { 
            if (HttpContext.Request.Cookies.Count > 0)
            {
                var siteCookies = HttpContext.Request.Cookies.Where(c => c.Key.Contains(".AspNetCore.") || c.Key.Contains("Microsoft.Authentication"));
            }

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}

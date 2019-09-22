using Microsoft.AspNetCore.Mvc;
using TestMenu.BusinessLayer;
using TestMenu.Models;

namespace TestMenu.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthorizationManager _authManager;

        public AccountController(AuthorizationManager authManager)
        {
            _authManager = authManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DoLogin(LoginModel loginModel)
        {
            var q = _authManager.Login(loginModel, HttpContext);

            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TestMenu.BusinessLayer;
using TestMenu.Models;
using TestMenu.Models.Models;

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

        //public IActionResult DoLogin(LoginModel loginModel)
        //{
        //    var q = _authManager.Login(loginModel, HttpContext);

        //    return Ok();
        //}

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}

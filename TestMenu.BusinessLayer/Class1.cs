using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using TestMenu.DataLayer;
using TestMenu.DataLayer.Store;
using TestMenu.Models;

namespace TestMenu.BusinessLayer
{
    public class AuthorizationManager
    {
        private readonly IUserStore _userStore;

        public AuthorizationManager(IUserStore userStore)
        {
            _userStore = userStore;
        }

        public async Task<bool> Login(LoginModel loginModel, HttpContext context)
        {
            var isUserExist = _userStore.GetUser(loginModel) != null;

            if (isUserExist)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Guid.NewGuid().ToString())
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await context.SignInAsync(
                    scheme: CookieAuthenticationDefaults.AuthenticationScheme,
                    principal: new ClaimsPrincipal(claimsIdentity));
            }

            return isUserExist;
        }

        public void Logout()
        {

        }

        private void Authorize()
        {

        }


    }
}

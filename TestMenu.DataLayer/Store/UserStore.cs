using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestMenu.Models;

namespace TestMenu.DataLayer.Store
{
    public class UserStore : IUserStore
    {
        private readonly ApplicationDbContext _context;

        public UserStore(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationUser GetUser(LoginModel loginModel)
        {
            return _context.ApplicationUsers.FirstOrDefault(x =>
                x.Login == loginModel.Login && x.Password == loginModel.Password);
        }

    }

    public interface IUserStore
    {
        ApplicationUser GetUser(LoginModel loginModel);
    }
}
//проверка связи
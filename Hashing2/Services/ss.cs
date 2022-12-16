using Hashing2.Models;

namespace Hashing2.Services
{
    public class ss : aa
    {
        UserService _userService;

        public ss(UserService userService)
        {
            _userService = userService;
        }
        public User GetByMail(string email)
        {
            return _userService.Get(u => u.Email == email);
        }
    }
}

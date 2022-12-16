using Hashing2.Models;
using System.Linq.Expressions;
using System.Security.Principal;

namespace Hashing2.Services
{
    public interface UserService
    {
        void Add(User user);
        User Get(Expression<Func<User, bool>> filter);

    }
}

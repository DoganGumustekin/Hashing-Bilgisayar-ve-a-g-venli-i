using Hashing2.DbContextWithEF;
using Hashing2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hashing2.Services
{
    public class UserManager: UserService
        
    {
        public void Add(User user)
        {
            using (SubscriptionContext subscriptionContext = new SubscriptionContext())
            {
                var addUser = subscriptionContext.Entry(user);
                addUser.State = EntityState.Added;
                subscriptionContext.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter) //expression filtre vermemizi sağlar.
        {
            using (SubscriptionContext subscriptionContext = new SubscriptionContext())
            {
                return subscriptionContext.Set<User>().SingleOrDefault(filter); // tek bir eleman bulduğumuzda döndüren fonksiyon singleordefault yada firstordefault
            }
        }
    }
}

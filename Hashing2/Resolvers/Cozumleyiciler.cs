using Autofac;
using Hashing2.Repos;
using Hashing2.Services;
using System.Reflection;

namespace Hashing2.Resolvers
{
    public class Cozumleyiciler : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthRepo>().As<AuthRepo>().SingleInstance();
            builder.RegisterType<UserManager>().As<UserService>().SingleInstance();

            builder.RegisterType<ss>().As<aa>().SingleInstance();
        }
        
    }
}

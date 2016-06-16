using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Account_Test.Startup))]
namespace Account_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

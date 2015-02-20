using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo.MalApi.Startup))]
namespace Demo.MalApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

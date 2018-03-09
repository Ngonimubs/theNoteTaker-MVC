using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(theNoteTaker_v1.Startup))]
namespace theNoteTaker_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDebugger.Startup))]
namespace WebDebugger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}

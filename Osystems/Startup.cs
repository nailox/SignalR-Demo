using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;

[assembly: OwinStartupAttribute(typeof(Osystems.Startup))]
namespace Osystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();

        }
    }
}

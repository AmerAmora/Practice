using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_tickets.Startup))]
namespace Movie_tickets
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

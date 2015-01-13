using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaceTickets.Startup))]
namespace FaceTickets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

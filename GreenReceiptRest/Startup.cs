using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenReceiptRest.Startup))]
namespace GreenReceiptRest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

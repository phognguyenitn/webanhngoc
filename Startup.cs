using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_AnhNgoc_Edition1.Startup))]
namespace Web_AnhNgoc_Edition1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

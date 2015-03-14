using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Address_Book.Startup))]
namespace Address_Book
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

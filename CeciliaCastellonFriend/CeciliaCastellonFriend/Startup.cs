using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CeciliaCastellonFriend.Startup))]
namespace CeciliaCastellonFriend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

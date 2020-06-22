using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_NguyenKhanhDuy.Startup))]
namespace Lab2_NguyenKhanhDuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

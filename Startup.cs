using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenMinhThu_2080601212.Startup))]
namespace NguyenMinhThu_2080601212
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

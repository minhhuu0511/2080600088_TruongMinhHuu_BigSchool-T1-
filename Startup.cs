using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2080600088_TruongMinhHuu_BigSchool_T1_.Startup))]
namespace _2080600088_TruongMinhHuu_BigSchool_T1_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

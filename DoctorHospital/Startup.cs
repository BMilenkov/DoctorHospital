using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoctorHospital.Startup))]
namespace DoctorHospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

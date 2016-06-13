using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebSites_Exam.Startup))]
namespace AzureWebSites_Exam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

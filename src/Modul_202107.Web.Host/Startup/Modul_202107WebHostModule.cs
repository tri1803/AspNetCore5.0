using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Modul_202107.Configuration;

namespace Modul_202107.Web.Host.Startup
{
    [DependsOn(
       typeof(Modul_202107WebCoreModule))]
    public class Modul_202107WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Modul_202107WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Modul_202107WebHostModule).GetAssembly());
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Modul_202107.Authorization;

namespace Modul_202107
{
    [DependsOn(
        typeof(Modul_202107CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Modul_202107ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Modul_202107AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Modul_202107ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Modul_202107.EntityFrameworkCore;
using Modul_202107.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Modul_202107.Web.Tests
{
    [DependsOn(
        typeof(Modul_202107WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Modul_202107WebTestModule : AbpModule
    {
        public Modul_202107WebTestModule(Modul_202107EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Modul_202107WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Modul_202107WebMvcModule).Assembly);
        }
    }
}
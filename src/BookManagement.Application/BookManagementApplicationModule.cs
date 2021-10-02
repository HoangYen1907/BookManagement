using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookManagement.Authorization;

namespace BookManagement
{
    [DependsOn(
        typeof(BookManagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BookManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BookManagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BookManagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

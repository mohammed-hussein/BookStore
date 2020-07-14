using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace STCS.Framework.Infrastructure
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpAutoMapperModule)
        )]
    public class FrameworkInfrastructureModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            // context.Services.AddApplication<FrameworkInfrastructureModule>();
            //context.Services.AddApplication<FrameworkInfrastructureModule>(options =>{
            //    options.UseAutofac();
            //});

            //context.Services.AddTransient(typeof(TaskRepository), typeof(ITaskRepository));

            context.Services.AddAutoMapperObjectMapper<FrameworkInfrastructureModule>();
            Configure<AbpAutoMapperOptions>(options => {
                options.AddMaps<FrameworkInfrastructureModule>();
                //options.AddProfile<FrameworkInfrastructureAutoMapperProfile>(validate: true);
            });
        }
    }
}

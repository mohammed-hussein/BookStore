using Acme.BookStore.EServices;
using AutoMapper;
using Newtonsoft.Json.Linq;

namespace Acme.BookStore.Infra
{
    public class FrameworkInfrastructureAutoMapperProfile : Profile
    {
        public FrameworkInfrastructureAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            // E-Services Task
            CreateMap<JObject, Task>()
                .ForMember(t => t.Title, opt => opt.MapFrom(jo => jo["title"]));
        }
    }
}

using AutoMapper;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Adapters.Profiles
{
    public class OrganisationDataModelProfile : Profile
    {
        public OrganisationDataModelProfile()
        {
            CreateMap<Organisation, OrganisationDataModel>()
                .ForMember(d => d.Id, c => c.MapFrom(f => f.Id))
                .ForMember(d => d.Name, c => c.MapFrom(f => f.Name));
        }
    }
}
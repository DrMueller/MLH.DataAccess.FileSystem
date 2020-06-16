using AutoMapper;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services.Implementation;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Adapters.Implementation
{
    public class OrganisationDataModelAdapter : DataModelAdapterBase<OrganisationDataModel, Organisation, string>, IOrganisationDataModelAdapter
    {
        public OrganisationDataModelAdapter(IMapper mapper)
            : base(mapper)
        {
        }

        public override Organisation Adapt(OrganisationDataModel dataModel)
        {
            return new Organisation(
                dataModel.Name,
                dataModel.Id);
        }
    }
}
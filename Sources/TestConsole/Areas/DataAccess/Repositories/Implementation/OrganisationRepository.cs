using Mmu.Mlh.DataAccess.Areas.Repositories;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Adapters;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.Implementation
{
    public class OrganisationRepository : RepositoryBase<Organisation, OrganisationDataModel, string>, IOrganisationRepository
    {
        public OrganisationRepository(
            IOrganisationDataModelRepository dataModelRepository,
            IOrganisationDataModelAdapter dataModelAdapter)
            : base(dataModelRepository, dataModelAdapter)
        {
        }
    }
}
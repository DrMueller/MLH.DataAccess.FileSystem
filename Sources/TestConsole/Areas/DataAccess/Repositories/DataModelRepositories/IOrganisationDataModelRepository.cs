using Mmu.Mlh.DataAccess.Areas.DatabaseAccess;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories
{
    public interface IOrganisationDataModelRepository : IDataModelRepository<OrganisationDataModel, string>
    {
    }
}
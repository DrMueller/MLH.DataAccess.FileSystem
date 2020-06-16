using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Implementation;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Implementation
{
    public class OrganisationDataModelRepository : FileSystemDataModelRepository<OrganisationDataModel>, IOrganisationDataModelRepository
    {
        public OrganisationDataModelRepository(
            IFileSystemProxy<OrganisationDataModel> fileSystemProxy,
            IDataModelFileAdapter<OrganisationDataModel> dataModelFileAdapter)
            : base(fileSystemProxy, dataModelFileAdapter)
        {
        }
    }
}
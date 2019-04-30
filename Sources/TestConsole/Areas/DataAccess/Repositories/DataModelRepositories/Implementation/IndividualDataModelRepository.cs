using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Implementation;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling.Adapters;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Implementation
{
    public class IndividualDataModelRepository : FileSystemDataModelRepository<IndividualDataModel, long>
    {
        public IndividualDataModelRepository(
            IFileSystemProxy fileSystemProxy,
            IndividualDataModelFileAdapter fileAdapter)
            : base(fileSystemProxy, fileAdapter)
        {
        }
    }
}

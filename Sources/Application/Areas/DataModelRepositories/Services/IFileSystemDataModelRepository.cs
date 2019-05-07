using Mmu.Mlh.DataAccess.Areas.DatabaseAccess;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services
{
    public interface IFileSystemDataModelRepository<T> : IDataModelRepository<T, string>
        where T : AggregateRootDataModel<string>
    {
    }
}

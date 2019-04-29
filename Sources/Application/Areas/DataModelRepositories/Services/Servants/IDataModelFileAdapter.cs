using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    public interface IDataModelFileAdapter<T, TId>
        where T : AggregateRootDataModel<TId>
    {
        File AdaptToFile(T dataModel);

        T AdaptToDataModel(File dataModelFile);
    }
}
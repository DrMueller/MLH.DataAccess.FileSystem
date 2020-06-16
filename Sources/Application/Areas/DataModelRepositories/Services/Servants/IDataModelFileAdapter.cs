using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    public interface IDataModelFileAdapter<T>
        where T : AggregateRootDataModel<string>
    {
        T AdaptToDataModel(File dataModelFile);

        File AdaptToFile(T dataModel);
    }
}
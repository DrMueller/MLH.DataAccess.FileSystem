using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants.Implementation
{
    public class DataModelFileAdapter<T, TId> : IDataModelFileAdapter<T, TId>
        where T : AggregateRootDataModel<TId>
    {
        public T AdaptToDataModel(File dataModelFile)
        {
            return JsonConvert.DeserializeObject<T>(dataModelFile.Content);
        }

        public File AdaptToFile(T dataModel)
        {
            var fileContent = JsonConvert.SerializeObject(dataModel);
            var fileName = string.Concat(dataModel.DataModelTypeName, "_", dataModel.Id);
            return new File(fileName, fileContent);
        }
    }
}
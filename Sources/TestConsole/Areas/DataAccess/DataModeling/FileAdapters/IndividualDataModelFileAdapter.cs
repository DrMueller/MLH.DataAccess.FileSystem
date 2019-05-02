using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling.Adapters
{
    public class IndividualDataModelFileAdapter : IDataModelFileAdapter<IndividualDataModel, long>
    {
        public IndividualDataModel AdaptToDataModel(File dataModelFile)
        {
            if (string.IsNullOrEmpty(dataModelFile.Content))
            {
                return new IndividualDataModel();
            }

            var result = JsonConvert.DeserializeObject<IndividualDataModel>(dataModelFile.Content);
            return result;
        }

        public File AdaptToFile(IndividualDataModel dataModel)
        {
            var content = JsonConvert.SerializeObject(dataModel);
            return new File(dataModel.Id.ToString(), content);
        }
    }
}

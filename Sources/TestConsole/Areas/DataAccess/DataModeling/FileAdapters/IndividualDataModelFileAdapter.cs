using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling.Adapters
{
    public class IndividualDataModelFileAdapter : IDataModelFileAdapter<IndividualDataModel, long>
    {
        public IndividualDataModel AdaptToDataModel(File dataModelFile)
        {
            return null;
        }

        public File AdaptToFile(IndividualDataModel dataModel)
        {
            return null;
        }
    }
}

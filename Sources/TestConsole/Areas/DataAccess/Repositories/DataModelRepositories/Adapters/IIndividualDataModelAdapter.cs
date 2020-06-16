using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Adapters
{
    public interface IIndividualDataModelAdapter : IDataModelAdapter<IndividualDataModel, Individual, string>
    {
    }
}
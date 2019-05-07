using AutoMapper;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services.Implementation;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories.DataModelRepositories.Adapters.Implementation
{
    public class IndividualDataModelAdapter : DataModelAdapterBase<IndividualDataModel, Individual, string>, IIndividualDataModelAdapter
    {
        public IndividualDataModelAdapter(IMapper mapper) : base(mapper)
        {
        }

        public override Individual Adapt(IndividualDataModel dataModel)
        {
            return new Individual(
                dataModel.FirstName,
                dataModel.LastName,
                dataModel.Birthdate,
                dataModel.Id);
        }
    }
}

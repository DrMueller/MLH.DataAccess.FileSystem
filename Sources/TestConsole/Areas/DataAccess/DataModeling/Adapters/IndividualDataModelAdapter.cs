using AutoMapper;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services.Implementation;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling.Adapters
{
    public class IndividualDataModelAdapter : DataModelAdapterBase<IndividualDataModel, Individual, long>
    {
        public IndividualDataModelAdapter(IMapper mapper) : base(mapper)
        {
        }

        public override Individual Adapt(IndividualDataModel dataModel)
        {
            return new Individual(
                dataModel.Id,
                dataModel.FirstName,
                dataModel.LastName,
                dataModel.Birthdate);
        }
    }
}

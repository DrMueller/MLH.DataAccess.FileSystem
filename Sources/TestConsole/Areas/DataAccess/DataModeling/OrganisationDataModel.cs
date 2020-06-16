using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling
{
    public class OrganisationDataModel : AggregateRootDataModel<string>
    {
        public string Name { get; set; }
    }
}
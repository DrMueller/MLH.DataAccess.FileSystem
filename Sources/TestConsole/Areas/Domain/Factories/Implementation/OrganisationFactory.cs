using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories.Implementation
{
    public class OrganisationFactory : IOrganisationFactory
    {
        public Organisation Create(string name, string id = null)
        {
            return new Organisation(name, id);
        }
    }
}
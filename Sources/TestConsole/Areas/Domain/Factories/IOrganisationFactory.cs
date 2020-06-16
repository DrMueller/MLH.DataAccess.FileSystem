using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories
{
    public interface IOrganisationFactory
    {
        Organisation Create(string name, string id = null);
    }
}
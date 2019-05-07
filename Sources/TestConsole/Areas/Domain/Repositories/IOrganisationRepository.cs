using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;
using Mmu.Mlh.DomainExtensions.Areas.Repositories;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories
{
    public interface IOrganisationRepository : IRepository<Organisation, string>
    {
    }
}

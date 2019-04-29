using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.FileSystem.Areas.IdGeneration.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.IdGeneration.Factories.Servants
{
    public interface IControlFileRepository
    {
        ControlFile Load();

        void Save(ControlFile controlFile);
    }
}

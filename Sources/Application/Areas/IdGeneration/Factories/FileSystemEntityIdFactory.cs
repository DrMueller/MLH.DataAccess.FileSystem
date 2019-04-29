using Mmu.Mlh.DataAccess.FileSystem.Areas.IdGeneration.Factories.Servants;
using Mmu.Mlh.DomainExtensions.Areas.Factories;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.IdGeneration.Factories
{
    public class FileSystemEntityIdFactory : IEntityIdFactory<long>
    {
        private readonly IControlFileRepository _controlFileRepository;

        public FileSystemEntityIdFactory(IControlFileRepository controlFileRepository)
        {
            _controlFileRepository = controlFileRepository;
        }

        public long CreateEntityId()
        {
            var controlFile = _controlFileRepository.Load();
            var nextId = controlFile.GetNextId();
            _controlFileRepository.Save(controlFile);

            return nextId;
        }
    }
}
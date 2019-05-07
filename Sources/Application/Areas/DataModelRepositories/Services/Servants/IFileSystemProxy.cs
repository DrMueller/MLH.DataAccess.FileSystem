using System.Collections.Generic;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    public interface IFileSystemProxy<T>
        where T : AggregateRootDataModel<string>
    {
        IReadOnlyCollection<File> LoadAllFiles();

        void DeleteFile(string id);

        void SaveFile(File file);
    }
}
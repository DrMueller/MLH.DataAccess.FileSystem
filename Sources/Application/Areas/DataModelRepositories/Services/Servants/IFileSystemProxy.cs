using System.Collections.Generic;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    // ReSharper disable once UnusedTypeParameter
    public interface IFileSystemProxy<T>
        where T : AggregateRootDataModel<string>
    {
        void DeleteFile(string id);

        IReadOnlyCollection<File> LoadAllFiles();

        void SaveFile(File file);
    }
}
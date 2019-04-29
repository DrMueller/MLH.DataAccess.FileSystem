using System.Collections.Generic;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    public interface IFileSystemProxy
    {
        IReadOnlyCollection<File> LoadAllFiles();

        void DeleteFile(string id);

        void SaveFile(File file);
    }
}
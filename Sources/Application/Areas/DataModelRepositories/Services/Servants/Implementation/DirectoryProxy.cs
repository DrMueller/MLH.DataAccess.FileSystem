using System.IO.Abstractions;
using Mmu.Mlh.DataAccess.FileSystem.Areas.Settings.Services;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants.Implementation
{
    internal class DirectoryProxy<T> : IDirectoryProxy<T>
    {
        private readonly IFileSystem _fileSystem;
        private readonly IFileSystemSettingsProvider _fileSystemSettingsProvider;

        public DirectoryProxy(
            IFileSystem fileSystem,
            IFileSystemSettingsProvider fileSystemSettingsProvider)
        {
            _fileSystem = fileSystem;
            _fileSystemSettingsProvider = fileSystemSettingsProvider;
        }

        public string GetDirectoryPathAndAssureExists()
        {
            var basePath = _fileSystemSettingsProvider.ProvideFileSystemSettings().DirectoryPath;
            var subPath = _fileSystem.Path.Combine(basePath, typeof(T).Name);

            if (!_fileSystem.Directory.Exists(subPath))
            {
                _fileSystem.Directory.CreateDirectory(subPath);
            }

            return subPath;
        }
    }
}
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models;
using Mmu.Mlh.DataAccess.FileSystem.Infrastructure.Settings.Services;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants.Implementation
{
    public class FileSystemProxy : IFileSystemProxy
    {
        private const string FileExtension = ".json";
        private readonly IFileSystem _fileSystem;
        private readonly IFileSystemSettingsProvider _fileSystemSettingsProvider;

        public FileSystemProxy(IFileSystem fileSystem, IFileSystemSettingsProvider fileSystemSettingsProvider)
        {
            _fileSystem = fileSystem;
            _fileSystemSettingsProvider = fileSystemSettingsProvider;
        }

        public void DeleteFile(string id)
        {
            var filePath = CreateFilePath(id);
            _fileSystem.Directory.Delete(filePath);
        }

        public IReadOnlyCollection<File> LoadAllFiles()
        {
            var files = EnumerateFilesInDefinedPath().Select(
                filePath =>
                {
                    var fileName = _fileSystem.Path.GetFileName(filePath);
                    var fileContent = _fileSystem.File.ReadAllText(filePath);
                    return new File(fileName, fileContent);
                });

            return files.ToList();
        }

        public void SaveFile(File file)
        {
            var filePath = CreateFilePath(file.FileName);
            _fileSystem.File.WriteAllText(filePath, file.Content);
        }

        private string CreateFilePath(string fileName)
        {
            var directoryPath = _fileSystemSettingsProvider.ProvideFileSystemSettings().DirectoryPath;

            var result = _fileSystem.Path.Combine(directoryPath, fileName, FileExtension);
            return result;
        }

        private IEnumerable<string> EnumerateFilesInDefinedPath()
        {
            var directoryPath = _fileSystemSettingsProvider.ProvideFileSystemSettings().DirectoryPath;
            return _fileSystem.Directory.EnumerateFiles(directoryPath);
        }
    }
}
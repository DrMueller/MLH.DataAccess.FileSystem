using Mmu.Mlh.DataAccess.FileSystem.Infrastructure.Settings.Models;
using Mmu.Mlh.DataAccess.FileSystem.Infrastructure.Settings.Services;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Infrastructure.Settings.Services
{
    public class SettingsProvider : IFileSystemSettingsProvider
    {
        public FileSystemSettings ProvideFileSystemSettings()
        {
            return new FileSystemSettings
            {
                DirectoryPath = @"C:\Users\Matthias\Desktop\Work\tra"
            };
        }
    }
}

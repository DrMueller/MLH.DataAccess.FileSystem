using Mmu.Mlh.DataAccess.FileSystem.Areas.Settings.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.Settings.Services;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Infrastructure.Settings.Services
{
    public class SettingsProvider : IFileSystemSettingsProvider
    {
        public FileSystemSettings ProvideFileSystemSettings()
        {
            return new FileSystemSettings
            {
                DirectoryPath = @"C:\Temp\Tra"
            };
        }
    }
}
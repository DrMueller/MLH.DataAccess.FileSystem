using Mmu.Mlh.DataAccess.FileSystem.Infrastructure.Settings.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Infrastructure.Settings.Services
{
    public interface IFileSystemSettingsProvider
    {
        FileSystemSettings ProvideFileSystemSettings();
    }
}
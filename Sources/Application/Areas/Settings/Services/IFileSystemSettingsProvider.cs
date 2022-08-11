using Mmu.Mlh.DataAccess.FileSystem.Areas.Settings.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.Settings.Services
{
    public interface IFileSystemSettingsProvider
    {
        FileSystemSettings ProvideFileSystemSettings();
    }
}
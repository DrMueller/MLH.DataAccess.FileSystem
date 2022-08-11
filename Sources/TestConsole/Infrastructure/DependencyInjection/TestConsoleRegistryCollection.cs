using Lamar;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.Settings.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Infrastructure.Settings.Services;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Infrastructure.DependencyInjection
{
    public class TestConsoleRegistryCollection : ServiceRegistry
    {
        public TestConsoleRegistryCollection()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType(typeof(TestConsoleRegistryCollection));
                    scanner.WithDefaultConventions();
                    scanner.AddAllTypesOf<IConsoleCommand>();
                });

            For<IFileSystemSettingsProvider>().Use<SettingsProvider>().Singleton();
        }
    }
}
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.DataAccess.FileSystem.Infrastructure.Settings.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Infrastructure.Settings.Services;
using StructureMap;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Infrastructure.DependencyInjection
{
    public class TestConsoleRegistry : Registry
    {
        public TestConsoleRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType(typeof(TestConsoleRegistry));
                    scanner.WithDefaultConventions();

                    scanner.AddAllTypesOf<IConsoleCommand>();
                });

            For<IFileSystemSettingsProvider>().Use<SettingsProvider>().Singleton();
        }
    }
}
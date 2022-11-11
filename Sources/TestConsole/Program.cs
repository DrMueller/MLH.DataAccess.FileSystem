using Lamar;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Services;
using Mmu.Mlh.ConsoleExtensions.Infrastructure.DependencyInjection;
using Mmu.Mlh.DataAccess.FileSystem.Infrastructure.DependencyInjection;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Models;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Services;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole
{
    public static class Program
    {
        public static void Main()
        {
            var containerConfig = ContainerConfiguration.CreateFromAssembly(typeof(Program).Assembly, initializeAutoMapper: true);
            var container2 = ServiceProvisioningInitializer.CreateContainer(containerConfig);
            container2
                .GetInstance<IConsoleCommandsStartupService>()
                .Start();

            var container = new Container(cfg =>
            {
                cfg.Scan(scanner =>
                {
                    scanner.AssemblyContainingType(typeof(Program));
                    scanner.AssemblyContainingType(typeof(DataAccessFileSystemRegistryCollection));
                    scanner.AssemblyContainingType<ConsoleExtensionsRegistryCollection>();

                    scanner.LookForRegistries();
                });
            });

            container.GetInstance<IConsoleCommandsStartupService>().Start();
        }
    }
}
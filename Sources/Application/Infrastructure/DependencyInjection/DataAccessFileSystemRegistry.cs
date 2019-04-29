using StructureMap;

namespace Mmu.Mlh.DataAccess.FileSystem.Infrastructure.DependencyInjection
{
    public class DataAccessFileSystemRegistry : Registry
    {
        public DataAccessFileSystemRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<DataAccessFileSystemRegistry>();
                    scanner.WithDefaultConventions();
                });
        }
    }
}
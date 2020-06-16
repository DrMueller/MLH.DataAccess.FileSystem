using System.IO.Abstractions;
using Lamar;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants.Implementation;

namespace Mmu.Mlh.DataAccess.FileSystem.Infrastructure.DependencyInjection
{
    public class DataAccessFileSystemRegistryCollection : ServiceRegistry
    {
        public DataAccessFileSystemRegistryCollection()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<DataAccessFileSystemRegistryCollection>();
                    scanner.WithDefaultConventions();
                });

            For<IFileSystem>().Use<System.IO.Abstractions.FileSystem>();
            For(typeof(IDirectoryProxy<>)).Use(typeof(DirectoryProxy<>)).Transient();
            For(typeof(IDataModelFileAdapter<>)).Use(typeof(DataModelFileAdapter<>)).Singleton();
            For(typeof(IFileSystemProxy<>)).Use(typeof(FileSystemProxy<>)).Singleton();
        }
    }
}
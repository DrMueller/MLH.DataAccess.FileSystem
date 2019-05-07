using System.IO.Abstractions;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants.Implementation;
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

            For<IFileSystem>().Use<System.IO.Abstractions.FileSystem>();
            For(typeof(IDirectoryProxy<>)).Use(typeof(DirectoryProxy<>)).Transient();
            For(typeof(IDataModelFileAdapter<>)).Use(typeof(DataModelFileAdapter<>)).Singleton();
            For(typeof(IFileSystemProxy<>)).Use(typeof(FileSystemProxy<>)).Singleton();
        }
    }
}
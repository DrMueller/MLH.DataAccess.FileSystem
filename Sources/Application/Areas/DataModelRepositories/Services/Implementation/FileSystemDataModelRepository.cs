using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Implementation
{
    public class FileSystemDataModelRepository<T> : IFileSystemDataModelRepository<T>
        where T : AggregateRootDataModel<string>
    {
        private readonly IDataModelFileAdapter<T> _dataModelFileAdapter;
        private readonly IFileSystemProxy<T> _fileProxy;

        public FileSystemDataModelRepository(
            IFileSystemProxy<T> fileSystemProxy,
            IDataModelFileAdapter<T> dataModelFileAdapter)
        {
            _fileProxy = fileSystemProxy;
            _dataModelFileAdapter = dataModelFileAdapter;
        }

        public Task DeleteAsync(string id)
        {
            _fileProxy.DeleteFile(id.ToString());
            return Task.CompletedTask;
        }

        public Task<IReadOnlyCollection<T>> LoadAsync(Expression<Func<T, bool>> predicate)
        {
            var compiledPredicate = predicate.Compile();

            var files = _fileProxy.LoadAllFiles();
            var dataModels = files
                .Select(file => _dataModelFileAdapter.AdaptToDataModel(file))
                .Where(compiledPredicate)
                .ToList();

            return Task.FromResult<IReadOnlyCollection<T>>(dataModels);
        }

        public async Task<T> LoadSingleAsync(Expression<Func<T, bool>> predicate)
        {
            var dataModels = await LoadAsync(predicate);
            return dataModels.SingleOrDefault();
        }

        public Task<T> SaveAsync(T aggregateRootDataModel)
        {
            if (string.IsNullOrEmpty(aggregateRootDataModel.Id))
            {
                aggregateRootDataModel.Id = Guid.NewGuid().ToString();
            }

            var file = _dataModelFileAdapter.AdaptToFile(aggregateRootDataModel);

            _fileProxy.SaveFile(file);
            return Task.FromResult(aggregateRootDataModel);
        }
    }
}
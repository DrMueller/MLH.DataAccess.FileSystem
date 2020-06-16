namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    // ReSharper disable once UnusedTypeParameter
    internal interface IDirectoryProxy<T>
    {
        string GetDirectoryPathAndAssureExists();
    }
}
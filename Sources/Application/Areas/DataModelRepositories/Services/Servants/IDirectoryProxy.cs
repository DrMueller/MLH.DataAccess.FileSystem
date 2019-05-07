namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Services.Servants
{
    internal interface IDirectoryProxy<T>
    {
        string GetDirectoryPathAndAssureExists();
    }
}

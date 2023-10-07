using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Abstractions.Models.FileEntry;
using FileBaseContext.Abstractions.Models.FileSet;
using FileBaseContext.Context.Models.Configurations;
using FileBaseContext.Context.Models.FileContext;
using First.WebApi.Models;

namespace First.WebApi.DataContext;

public class AppFIleCantext :FileContext,IDataContext
{

    public IFileSet<Product, Guid> Products => Set<Product, Guid>(nameof(Products));
    public AppFIleCantext(IFileContextOptions<IFileContext> fileContextOptions) : base(fileContextOptions)
    {
        OnSaveChanges += AddPrimaryKeys;
    }
    public ValueTask AddPrimaryKeys(IEnumerable<IFileSetBase> fileSets)
    {
        foreach (var fileSet in fileSets)
            foreach (var entry in fileSet.GetEntries())
            {
                if (entry is not IFileEntityEntry<IEntity> entityEntry) continue;

                if (entityEntry.State == FileEntityState.Added)
                    entityEntry.Entity.Id = Guid.NewGuid();

                if (entry is not IFileEntityEntry<IFileSetEntity<Guid>> fileSetEntry) continue;
            }

        return new ValueTask(Task.CompletedTask);
    }
    public ValueTask DisposeAsync()
    {
        return new ValueTask(Task.CompletedTask);
    }

}

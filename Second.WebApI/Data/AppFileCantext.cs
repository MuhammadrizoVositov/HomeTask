using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Abstractions.Models.FileEntry;
using FileBaseContext.Abstractions.Models.FileSet;
using FileBaseContext.Context.Models.Configurations;
using FileBaseContext.Context.Models.FileContext;
using Second.WebApI.Models;

namespace Second.WebApI.Data
{
    public class AppFileCantext : FileContext,IDataCantext
    {
        public AppFileCantext(IFileContextOptions<IFileContext> fileContextOptions) : base(fileContextOptions)
        {
            OnSaveChanges += AddPrimaryKeys;
        }

        public IFileSet<User, Guid> Users => Set<User,Guid>(nameof(Users));

        public IFileSet<Order, Guid> Orders => Set<Order, Guid>(nameof(Orders));

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
}
namespace FileExplore.API.Models
{
    public class StorageFile : IStorageInfo
    {
        public string Name { get; set ; }
        public string Path { get; set ; }
        public long Size { get; set ; }
        public StorageEntryType EntryType { get ; set ; }
    }
}

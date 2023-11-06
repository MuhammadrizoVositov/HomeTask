namespace FileExplore.API.Models
{
    public class StorageDirectory : IStorageInfo
    {
        public string  Name { get; set; }
        public string Path { get; set; }
        public int ItemsCount { get; set; }
        public StorageEntryType EntryType { get ; set ; }
    }
}

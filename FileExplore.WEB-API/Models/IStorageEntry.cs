namespace FileExplore.WEB_API.Models
{
    public interface IStorageEntry
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public StorageEntryType EntryType { get; set; }
    }
}

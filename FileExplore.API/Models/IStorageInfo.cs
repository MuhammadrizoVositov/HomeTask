namespace FileExplore.API.Models
{
    public interface IStorageInfo
    {
        string Name { get; set; }
        string Path { get; set; }   
        StorageEntryType EntryType { get; set; }
        
    }
}

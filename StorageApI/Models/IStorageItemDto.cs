namespace StorageApI.Models
{
    public interface IStorageItemDto
    {
        string Path { get; set; }

        StorageItemType ItemType { get; set; }
    }
}

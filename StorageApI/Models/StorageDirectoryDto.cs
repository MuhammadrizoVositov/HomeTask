﻿namespace StorageApI.Models
{
    public class StorageDirectoryDto
    {
        public string Name { get; set; } = string.Empty;

        public string Path { get; set; } = string.Empty;

        public long ItemsCount { get; set; }

        public StorageItemType ItemType
        {
            get; set;

        }
    }
}

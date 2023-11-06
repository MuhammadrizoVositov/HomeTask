﻿namespace FileExplore.WEB_API.Controllers
{
    internal class StorageDrive
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Format { get; set; }
        public string Type { get; set; }
        public long TotalSpace { get; set; }
        public long FreeSpace { get; set; }
        public long UnavailableSpace { get; set; }
        public long UsedSpace { get; set; }
    }
}
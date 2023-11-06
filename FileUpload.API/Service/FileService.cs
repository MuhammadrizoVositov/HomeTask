using FileUpload.API.Entities;

namespace FileUpload.API.Service
{
    public class FileService
    {
        private readonly StorageFileService _storageFileService;

        public FileService(StorageFileService storageFileService) =>
                _storageFileService = storageFileService;

        public async ValueTask<StorageFile> Upload(Guid userId, string directoryName, IFormFile fileStream) =>
       await _storageFileService.Create(userId, directoryName, fileStream);

        public async ValueTask<bool> Delete(string filePath) =>
       await _storageFileService.Delete(filePath);
    }
}

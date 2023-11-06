using FileExplore.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileExplore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        [HttpGet("root/entry")]
        public ValueTask<IActionResult> Get([FromServices] IWebHostEnvironment webHostEnvironment )
        {
            var rootPath = webHostEnvironment.WebRootPath;
            var fileDirectory = Directory.EnumerateDirectories(rootPath);
            var files = Directory.EnumerateFiles(rootPath);
            var select = fileDirectory.Select(i =>
            {
                var dir = new DirectoryInfo(i);
                return new StorageDirectory()
                {
                    Name = dir.Name,
                    Path = dir.FullName,
                    ItemsCount = dir.EnumerateFileSystemInfos().Count()
                };
            });

            return new ValueTask<IActionResult>(Ok(select));
        }
        
    }
}

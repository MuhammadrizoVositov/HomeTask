using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_55_HT_1
{
    public class FileSave : IFileSave1
    {
        string projectFile=AppDomain.CurrentDomain.BaseDirectory;
        public int GetDirectoryCount()
        {
            var direcorycount=Directory.GetDirectories(projectFile).Length;
            return direcorycount;
        }

        public int GetFileCount()
        {
            var getFilecount=Directory.GetFiles(projectFile).Length;
            return getFilecount;
        }

        public string GetLargestFile()
        {
            var fileLargest = Directory.GetFiles(projectFile, ".", SearchOption.AllDirectories);
            var filelargest=fileLargest.OrderByDescending(f => new FileInfo(f).Length).First();
            return filelargest;
        }

        public long GetTotalSize()
        {
            var file=Directory.GetFiles(projectFile,".",SearchOption.AllDirectories);
            var longsizetotal=file.Sum(f => new FileInfo(f).Length);
            return longsizetotal;
        }
    }
}

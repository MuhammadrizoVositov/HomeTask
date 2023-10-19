using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_55_HT_1
{
    public interface IFileSave1
    {
        public int GetDirectoryCount();
        public int GetFileCount();
        public long GetTotalSize();
        public string GetLargestFile();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N43_HT_1
{
    public class AccountService
    {
        public async ValueTask<FileStream> CreateReportAsync(int id)
        {
            var mutex = new Mutex(false, "Report");
            
             return await Task.Run(async () =>
            {
                mutex.WaitOne();
                var file = File.Create("Report.txt");
                file.Close();

                File.WriteAllText("Report.txt", "Bahodir jalolovga yozildi");
                mutex.ReleaseMutex();
                return file;
            });
        }

    }
}

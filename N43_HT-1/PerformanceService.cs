using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N43_HT_1
{
    public class PerformanceService
    {
        public  async ValueTask<string> ReportPerformanceAsync(int id)
        {
            var mutex = new Mutex(false, "Email");
            
            return await Task.Run(() =>
            {
                mutex.WaitOne();
                var file = File.ReadAllText(@"GaniGaniyev.txt");
                File.WriteAllText(@"C:\Users\rizo2\source\repos\3-thrd_Lesson\N43_HT-1\bin\Debug\net7.0\GaniGaniyev.txt", "All Good");
                return file;

            });
        }
    }
}

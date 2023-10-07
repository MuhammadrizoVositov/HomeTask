


using System.Text;

var mutex = new Mutex(false, "Email");
File.WriteAllText("text.txt", "");
await Task.Run(() =>
{
    mutex.WaitOne();
    var file = File.Open("text.txt", FileMode.Open, FileAccess.ReadWrite);
    file.Write(Encoding.UTF8.GetBytes("Hello, {{UserName}}"));
    Thread.Sleep(10000);
    file.Close();
    mutex.ReleaseMutex();
});


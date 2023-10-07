using System.Text;

var mutex = new Mutex(false, "Email");
await Task.Run(() => // 2 thread boshlanyapti
{
    mutex.WaitOne();
    var file = File.ReadAllText(@"C:\Users\rizo2\source\repos\3-thrd_Lesson\N43-Task1\bin\Debug\net7.0\text.txt");
    file = file.Replace("{{UserName}}", "Muhammad rizo");// Tempalate
    File.WriteAllText(@"C:\Users\rizo2\source\repos\3-thrd_Lesson\N43-Task1\bin\Debug\net7.0\text.txt", file);

    mutex.ReleaseMutex();
});
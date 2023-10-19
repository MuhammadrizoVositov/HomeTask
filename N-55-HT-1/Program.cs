

var a = AppDomain.CurrentDomain.BaseDirectory;

Console.WriteLine(a);
var path = Directory.GetFiles(a);

Console.WriteLine(new FileInfo(path[0]).Length.ToString() + " " + path[0]);


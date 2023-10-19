


//creating folder
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

var folderPath = @"C:\Users\rizo2\source\repos\3-thrd_Lesson\Files\bin\Debug\net7.0";
var filename = "Storage";
var users = new List<User>
{
    new(){Id = Guid.NewGuid(),FirstName="Gani",LastName="Gopporov"},
    new(){Id = Guid.NewGuid(),FirstName="Gani",LastName="Gopporov"},
    new(){Id = Guid.NewGuid(),FirstName="Gani",LastName="Gopporov"},
    new(){Id = Guid.NewGuid(),FirstName="Gani",LastName="adsad"},
};
var fullPath = Path.Combine(folderPath, filename);
Directory.CreateDirectory(fullPath);
for (var i = 0; i < users.Count; i++)
{
    var userFolder = Path.Combine(fullPath, $"User{i}");
    Directory.CreateDirectory(userFolder);
    var filePath = Path.Combine(userFolder, $"{users[i].Id}.json");
    File.WriteAllText(filePath, JsonSerializer.Serialize(users[i]));
    var a = File.Create(Path.Combine(userFolder, "file3.jpg"));
    var a1 = File.Create(Path.Combine(userFolder, "profile.pdf"));
    var a2 = File.Create(Path.Combine(userFolder, "file4.txt"));
    var a3 = File.Create(Path.Combine(userFolder, "file2.docx"));
    a .Close();
    a1.Close();
    a2.Close();
    a3.Close();
}

foreach (var file in Directory.GetFiles(fullPath,"*",SearchOption.AllDirectories))
{
    if (!ImageFile(file) && new FileInfo(file).Length < 60 * 1024)
    {
        File.Delete(file);
        Console.WriteLine($"{file} deleted from the in Profile folder ");
    }
    continue;
}
foreach (var file in Directory.GetFiles(fullPath))
{
    if (!IsDocumenFile(file))
    {
        Console.WriteLine(file);
    }

}

bool IsDocumenFile(string file)
{
    var filesDocument = Path.GetExtension(file);
    return filesDocument == ".doc" || filesDocument == ".docx" || filesDocument == ".pdf";
}
Console.WriteLine("All file are deleted succesfully ");
bool ImageFile(string filename)
{
    var fileImage = Path.GetExtension(fullPath).ToLower();
    return fileImage == ".png" || fileImage == ".jpg" || fileImage == ".jpeg" || fileImage == ".gif";
}
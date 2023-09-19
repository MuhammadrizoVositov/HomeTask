
using N39_HT1;



List<object> objects = new List<object>
{
    new WeatherReport{State="New York",Degree=30},
    new WeatherReport{State="California",Degree=50},
    new WeatherReport{State="WashingTon",Degree=14},
    new WeatherReport{State="Arizona",Degree=-14},
    new WeatherReport{State="Maskva",Degree=-25},
    new User{FirstName="Bobur",LastName="Jorayev"},
    new User{FirstName="Mavlonbek",LastName="Isroilov"}
};
Console.WriteLine("20 C  dan oshiq bilgan havo malumotlari:");
var HotWeatherreport=objects.OfType<WeatherReport>().Where(x => x.Degree>20);
foreach(var report in HotWeatherreport)
{
    Console.WriteLine($"{report.State} {report.Degree} ");
}

Console.WriteLine("\\FirstName\\Bobur\\ Ga mos keladigan foydalanuvchilar: ");
var users = objects.OfType<User>().Where(u => u.FirstName == "Bobur");
foreach(var user in users)
{
    Console.WriteLine($"{user.FirstName} {user.LastName} ");
}
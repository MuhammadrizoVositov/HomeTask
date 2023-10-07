


using N43_HT_1;

var userService = new UserServise();
userService.Create(new User { Id = 1, FirstName = "Gani", LastName = "Ganiyev" });
userService.Create(new User { Id = 2, FirstName = "Alijon", LastName = "Ganiyevjon" });
userService.Create(new User { Id = 3, FirstName = "Bahodir", LastName = "Jalolov" });
var file = await userService.CreatePerformanceRecordAsync(1);
var Servise=new PerformanceService();
var files = await Servise.ReportPerformanceAsync(2);
var accaunt=new AccountService();
var accountservise=await accaunt.CreateReportAsync(3);





using HT_1.Models;
using N44_HT_1;

var cancelationToken = new CancellationTokenSource(5000);
var service = new Delayedd();
Console.WriteLine(await service.GetFullname(cancelationToken.Token,new User { FirstName = "Gani", LastName = "Gopper" }));

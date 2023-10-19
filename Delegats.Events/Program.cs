using Delegats.Events.Controllers;
using Delegats.Events.Models;
using Delegats.Events.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var b = new Discovery(new EmailEventService());
builder.Services.AddSingleton<UserService>()
    .AddSingleton<Discovery>(b)
    .AddSingleton<EmailCollection>()
    .AddSingleton<EmailEventService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
var servise =  builder.Services.BuildServiceProvider();
var discoveryServise = servise.GetRequiredService<Discovery>();
servise.GetRequiredService<EmailEventService>();
var a = await discoveryServise.HandEmailCreated(new User { FirstName = "bobur" });
Console.WriteLine(a);

app.Run();

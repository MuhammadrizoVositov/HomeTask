using FileBaseContext.Context.Models.Configurations;
using Second.WebApI.Data;
using Second.WebApI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var bulider = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserRepository>();



builder.Services.AddScoped<IDataCantext, AppFileCantext>(_ =>
{
    var contextOptions = new FileContextOptions<AppFileCantext>
    {
        StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage")
    };

    var context = new AppFileCantext(contextOptions);
    context.FetchAsync().AsTask().Wait();

    return context;
});
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

app.Run();

using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
var assables=Assembly
    .GetExecutingAssembly()
    .GetReferencedAssemblies()
    .Select(Assembly.Load)
    .ToList();

assables.Add(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(assables);
//builder.Services.AddSingleton<>
builder.Services.AddCors(option =>

{ option.AddDefaultPolicy(config =>
   {
            config.AllowAnyHeader();
            config.AllowAnyMethod();
            config.AllowAnyOrigin();
   });
});

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();//.AddNewtonsoftJson();
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

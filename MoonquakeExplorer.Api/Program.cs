using Microsoft.EntityFrameworkCore;
using MoonquakeExplorer.Data;
using MoonquakeExplorer.Data.NASA;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient<INasaClient, NasaClient>();
builder.Services.AddSingleton<IMoonquakeParser, MoonquakeParser>();
builder.Services.AddScoped<MoonquakeService>();

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<MoonquakeDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MoonquakeDb")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.Run();

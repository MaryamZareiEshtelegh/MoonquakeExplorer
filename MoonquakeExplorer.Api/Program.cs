using Microsoft.EntityFrameworkCore;
using MoonquakeExplorer.Data;
using MoonquakeExplorer.Data.Mapping;
using MoonquakeExplorer.Data.NASA;
using MoonquakeExplorer.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient<INasaClient, NasaClient>();
builder.Services.AddSingleton<IMoonquakeParser, MoonquakeParser>();
builder.Services.AddScoped<MoonquakeService>();
builder.Services.AddScoped<IMoonquakeRepository, MoonquakeRepository>();
builder.Services.AddScoped<MoonquakeMapper>();

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<MoonquakeDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("MoonquakeDb")));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.Run();

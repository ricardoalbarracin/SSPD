using Core.Data;
using GN.Sanidad.Lamia.EntityFrameworkCore.DataAccess;
using Infrastructure.Data.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
        .SetBasePath(builder.Environment.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .Build();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LamiaDbContext>(options => options.UseOracle(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);
builder.Services.AddTransient<IViewAcuRedesRepository, ViewAcuRedesRepository>();
builder.Services.AddTransient<IViewRedesAlcantarilladoRepository, ViewRedesAlcantarilladoRepository>();
builder.Services.AddTransient<IViewTratamientosAguasResidualesRepository, ViewTratamientosAguasResidualesRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();

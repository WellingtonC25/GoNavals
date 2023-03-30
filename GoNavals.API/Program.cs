using GoNavals.API.Services.Ciudad;
using GoNavals.API.Services.Color;
using GoNavals.API.Services.Comandancia;
using GoNavals.API.Services.Comandante;
using GoNavals.API.Services.ComandanteComandancia;
using Microsoft.EntityFrameworkCore.Query.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICiudadService, CiudadService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<IComandanciaService, ComandanciaService>();
builder.Services.AddScoped<IComandanteService, ComandanteService>();
builder.Services.AddScoped<IComandanteComandanciaService, ComandanteComandanciaService>();
builder.Services.AddDbContext<GoNavals.Domain.DataContext>();

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

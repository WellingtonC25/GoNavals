using GoNavals.BusinessLogic.Services.Ciudad;
using GoNavals.BusinessLogic.Services.Color;
using GoNavals.BusinessLogic.Services.Comandancia;
using GoNavals.BusinessLogic.Services.Comandante;
using GoNavals.BusinessLogic.Services.ComandanteComandancia;
using GoNavals.BusinessLogic.Services.Constructora;
using GoNavals.BusinessLogic.Services.Curso;
using GoNavals.BusinessLogic.Services.Embarcacion;
using GoNavals.BusinessLogic.Services.Ocupacion;
using GoNavals.BusinessLogic.Services.Pais;
using GoNavals.BusinessLogic.Services.Propietario;
using GoNavals.BusinessLogic.Services.Puerto;
using GoNavals.BusinessLogic.Services.Rango;
using GoNavals.BusinessLogic.Services.TipoUso;
using GoNavals.BusinessLogic.Services.Zona;
using GoNavals.Core;
using GoNavals.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;

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
builder.Services.AddScoped<IConstructoraService, ConstructoraService>();
builder.Services.AddScoped<ICursoService, CursoService>();
builder.Services.AddScoped<IEmbarcacionService, EmbarcacionService>();
builder.Services.AddScoped<IOcupacionService, OcupacionService>();
builder.Services.AddScoped<IPaisService, PaisService>();
builder.Services.AddScoped<IPropietarioService, PropietarioService>();
builder.Services.AddScoped<IPuertoService, PuertoService>();
builder.Services.AddScoped<IRangoService, RangoService>();
builder.Services.AddScoped<ITipoUsoService, TipoUsoService>();
builder.Services.AddScoped<IZonaService, ZonaService>();
builder.Services.AddDbContext<GoNavals.Domain.DataContext>();
builder.Services.AddCors();

 builder.Services.AddMvc().AddNewtonsoftJson(o =>
{
    o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
});

builder.Services.AddControllers(
options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.WithOrigins("http://localhost:3000");
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

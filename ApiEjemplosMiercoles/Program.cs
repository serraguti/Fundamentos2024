using ApiEjemplosMiercoles.Data;
using ApiEjemplosMiercoles.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//DEBEMOS AGREGAR EL REPOSITORIO
builder.Services.AddTransient<RepositoryEmpleados>();
//DESDE EL BUILDER, TENEMOS CONFIGURATION PARA ACCEDER A APPSETTINGS.JSON
//Y RECUPERAR NUESTRA CADENA DE CONEXION
string connectionString =
    builder.Configuration.GetConnectionString("HospitalSQL");
//AGREGAMOS NUESTRO DBCONTEXT PARA NUESTRO SERVICIO API
builder.Services.AddDbContext<HospitalContext>
    (options => options.UseSqlServer(connectionString));

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

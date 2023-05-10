//1. Importamos el paquete necesario
using Microsoft.EntityFrameworkCore;
using Model;
using WebAPI.Services.Interfaces;
using WebAPI.Services.Classes;

var builder = WebApplication.CreateBuilder(args);

//2. Obtener la cadena de conexion
const string CONNECTIONNAME = "ScheduleDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Agregar el contexto
builder.Services.AddDbContext<ScheduleDbContext>(options => options.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllers();

//Se agrega a los servicios implementados
builder.Services.AddScoped<ISubjectService, SubjectService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//.5 Habilitar la Politica CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});


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

//Decirle a la aplicacion que haga uso de cors
app.UseCors("CorsPolicy");

app.Run();

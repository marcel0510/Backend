 //1. Importamos el paquete necesario
using Microsoft.EntityFrameworkCore;
using Model;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI.Secutiry;
using Model.DAL.Interfaces;
using Model.DAL.Classes;

var builder = WebApplication.CreateBuilder(args);

//2. Obtener la cadena de conexion
const string CONNECTIONNAME = "ScheduleDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

var configuration = builder.Configuration;  

//3. Agregar el contexto
builder.Services.AddDbContext<ScheduleDbContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.EnableSensitiveDataLogging();
});
// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    //Que se ignoren los ciclos que contienen unas a otras
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

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

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TknKey"])),
            ValidateIssuer = false,
            ValidateAudience = false,

        };
    });

//Agregar el AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IBuildingDAL, BuildingDAL>();
builder.Services.AddScoped<ICalendarDAL, CalendarDAL>();
builder.Services.AddScoped<IClassroomDAL, ClassroomDAL>();
builder.Services.AddScoped<IGroupDAL, GroupDAL>();
builder.Services.AddScoped<ISubjectDAL, SubjectDAL>();
builder.Services.AddScoped<IUserDAL, UserDAL>();

var app = builder.Build();

//Agregar configuracion de token


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();    
app.UseAuthorization();
app.MapControllers();

app.UseCors("CorsPolicy");

//Decirle a la aplicacion que haga uso de cors

app.Run();

using NetByForms.Application.Configurations;
using NetByForms.Infrastructure.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de CORS para permitir cualquier origen, método y encabezado
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        _ = policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Configuración personalizada de servicios
builder.Services.ConfigureAppServices();
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureRepositories();

// Construcción de la aplicación
var app = builder.Build();

// Configuración del pipeline de la aplicación
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

// Activar CORS con la política por defecto configurada previamente
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
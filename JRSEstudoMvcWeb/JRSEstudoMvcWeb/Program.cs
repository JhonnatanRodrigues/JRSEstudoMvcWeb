using JRSEstudoMvcWeb_Aplicacao.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Repositorio.Configs;
using JRSEstudoMvcWeb_Repositorio.Usuarios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContextoBanco>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IAplicUsuario, AplicUsuario>();
builder.Services.AddScoped<IRepUsuario, RepUsuario>();

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

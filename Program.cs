// Program.cs
using Microsoft.EntityFrameworkCore;
using ChallengeMottu.Data;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.Infrastructure.Data.Repositories;
using ChallengeMottu.Application.Interfaces;
using ChallengeMottu.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// 1) Configurar o DbContext para Oracle
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2) Registrar Repositório e Serviço de Aplicação
builder.Services.AddScoped<IMotoRepository, MotoRepository>();
builder.Services.AddScoped<IMotoApplicationService, MotoApplicationService>();

// 3) Adicionar controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 4) Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

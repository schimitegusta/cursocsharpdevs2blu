using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Interfaces.Repositories;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Data;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Repositories;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.Interfaces;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Context SQL Server
var connectionStringUser = builder.Configuration.GetConnectionString("SQLServerConnection");
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer(connectionStringUser));

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();

//Context SQL Server sempore antes do Build();
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
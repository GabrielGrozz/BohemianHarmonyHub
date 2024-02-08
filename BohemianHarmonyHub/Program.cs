using BohemianHarmonyHub.Context;
using BohemianHarmonyHub.Repositories;
using BohemianHarmonyHub.Repositories.Interfaces;
using BohemianHarmonyHub.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string connectionStringMySql = builder.Configuration.GetConnectionString("connectionStringMySql");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionStringMySql, ServerVersion.AutoDetect(connectionStringMySql)));
builder.Services.AddScoped<IBandRepository, BandRepository>();
builder.Services.AddScoped<IBandMemberRepository, BandMemberRepository>();

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

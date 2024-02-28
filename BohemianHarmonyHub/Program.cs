using BohemianHarmonyHub.Context;
using BohemianHarmonyHub.Repositories;
using BohemianHarmonyHub.Repositories.Interfaces;
using BohemianHarmonyHub.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string connectionStringMySql = builder.Configuration.GetConnectionString("connectionStringMySql");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionStringMySql, ServerVersion.AutoDetect(connectionStringMySql)));
builder.Services.AddScoped<IBandRepository, BandRepository>();
builder.Services.AddScoped<IBandMemberRepository, BandMemberRepository>();
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.AddControllers().AddJsonOptions(op =>
    op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
    );
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

app.UseCors(options =>
{
    options.WithOrigins("https://localhost:3000/");
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

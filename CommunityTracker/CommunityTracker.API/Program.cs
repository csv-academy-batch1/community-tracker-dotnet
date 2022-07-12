using CommunityTracker.Repository;
using CommunityTracker.Repository.Command;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddScoped<ICommunityRepositoryCommands, CommunityRepositoryCommands>();
builder.Services.AddScoped<ICommunityServiceCommands, CommunityServiceCommands>();
builder.Services.AddDbContext<AppDataContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

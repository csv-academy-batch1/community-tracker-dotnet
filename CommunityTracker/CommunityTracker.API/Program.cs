using CommunityTracker.Repository.Command;
using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICommunityRepositoryCommands, CommunityRepositoryCommands>();
builder.Services.AddScoped<ICommunityServiceCommands, CommunityServiceCommands>();
builder.Services.AddDbContext<AppDataContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();


var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
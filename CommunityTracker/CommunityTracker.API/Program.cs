using CommunityTracker.Repository.Command;
using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.Query;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ICommunityRepositoryCommands, CommunityRepositoryCommands>();
builder.Services.AddScoped<ICommunityRepositoryQuery, CommunityRepositoryQuery>();
builder.Services.AddScoped<ICommunityServiceCommands, CommunityServiceCommands>();
builder.Services.AddScoped<ICommunityServiceQuery, CommunityServiceQuery>();
builder.Services.AddDbContext<CommunityDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
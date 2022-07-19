using CommunityTracker.Repository.Commands;
using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.Queries;
using CommunityTracker.Service.Commands;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddScoped<ICommunityRepositoryCommands, CommunityRepositoryCommands>();
builder.Services.AddScoped<ICommunityRepositoryQueries, CommunityRepositoryQueries>();
builder.Services.AddScoped<ICommunityServiceCommands, CommunityServiceCommands>();
builder.Services.AddScoped<ICommunityServiceQueries, CommunityServiceQueries>();
builder.Services.AddDbContext<CommunityDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
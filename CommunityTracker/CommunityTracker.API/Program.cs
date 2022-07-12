using CommunityTracker.Repository.Command;
using CommunityTracker.Repository.Data_Context;
using CommunityTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();


var app = builder.Build();
//builder.Services.AddScoped<ICommunityCommands, CommunityCommands>;
//builder.Services.AddScoped<ICommunityCommands, CommunityCommands>;
builder.Services.AddDbContext<CommunityDBContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

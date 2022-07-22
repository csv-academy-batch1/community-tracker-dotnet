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
ConfiguredServices(builder.Services);

builder.Services.AddControllers().AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = null);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void ConfiguredServices(IServiceCollection services)
{
    services.AddScoped<ICommunityRepositoryCommands, CommunityRepositoryCommands>();
    services.AddScoped<ICommunityRepositoryQueries, CommunityRepositoryQueries>();
    services.AddScoped<ICommunityRepositoryMembers, CommunityMembersRepository>();

    services.AddScoped<ICommunityServiceCommands, CommunityServiceCommands>();
    services.AddScoped<ICommunityServiceQueries, CommunityServiceQueries>();
    services.AddScoped<ICommunityMembersService, CommunityMembersService>();
    services.AddDbContext<CommunityDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
}
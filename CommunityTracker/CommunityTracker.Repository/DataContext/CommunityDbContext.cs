using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.DataContext
{
    public class CommunityDbContext : DbContext
    {
        public CommunityDbContext(DbContextOptions<CommunityDbContext> options) : base(options)
        {
        }

        public DbSet<Community> community { get; set; }
        public DbSet<CommunityManagers> communityadminandmanager { get; set; }
    }
}
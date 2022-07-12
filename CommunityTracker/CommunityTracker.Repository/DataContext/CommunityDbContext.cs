using CommunityTracker.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.DataContext
{
    public class CommunityDbContext : DbContext
    {
        public CommunityDbContext(DbContextOptions<CommunityDbContext> options) : base(options)
        {
        }
        public DbSet<CommunityData> community { get; set; }
    }
}

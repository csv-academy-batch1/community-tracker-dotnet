using CommunityTracker.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository
{  
    public class AppDataContext : DbContext
    {
         public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
         {
         }
         public DbSet<EntityTable> Items { get; set; }
        
    }
}

using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace CommunityTracker.Repository.DataContext
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class CommunityDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public CommunityDbContext(DbContextOptions<CommunityDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the community.
        /// </summary>
        /// <value>
        /// The community.
        /// </value>
        public DbSet<Community> community { get; set; }

        /// <summary>
        /// Gets or sets the communityadminandmanager.
        /// </summary>
        /// <value>
        /// The communityadminandmanager.
        /// </value>
        public DbSet<CommunityManagers> communityadminandmanager { get; set; }
    }
}
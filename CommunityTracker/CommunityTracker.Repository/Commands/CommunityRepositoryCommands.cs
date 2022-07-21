using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Commands
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryCommands" />
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>
        /// The community database context
        /// </summary>
        private readonly CommunityDbContext _communityDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityRepositoryCommands"/> class.
        /// </summary>
        /// <param name="communityDbContext">The community database context.</param>
        public CommunityRepositoryCommands(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }

        private async Task SaveChangesAsync()
        {
            await _communityDbContext.SaveChangesAsync();
        }
    }
}
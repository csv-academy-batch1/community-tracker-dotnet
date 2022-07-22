using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Queries
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryQueries" />
    public partial class CommunityRepositoryQueries : ICommunityRepositoryQueries
    {
        /// <summary>
        /// The community database context
        /// </summary>
        private readonly CommunityDbContext _communityDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityRepositoryQueries" /> class.
        /// </summary>
        /// <param name="communityDbContext">The community database context.</param>
        public CommunityRepositoryQueries(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}
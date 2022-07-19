using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Queries
{
    public partial class CommunityRepositoryQueries : ICommunityRepositoryQueries
    {
        private readonly CommunityDbContext _communityDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityRepositoryQueries"/> class.
        /// </summary>
        /// <param name="communityDbContext">The community database context.</param>
        public CommunityRepositoryQueries(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}
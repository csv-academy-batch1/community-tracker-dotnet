using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Queries
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        private readonly CommunityDbContext _communityDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityRepositoryQuery"/> class.
        /// </summary>
        /// <param name="communityDbContext">The community database context.</param>
        public CommunityRepositoryQuery(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}
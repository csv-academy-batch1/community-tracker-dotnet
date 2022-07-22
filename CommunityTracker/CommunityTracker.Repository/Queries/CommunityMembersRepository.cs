using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Queries
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryMembers" />
    public partial class CommunityMembersRepository : ICommunityRepositoryMembers
    {
        /// <summary>
        /// The community database context
        /// </summary>
        private readonly CommunityDbContext _communityDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityMembersRepository"/> class.
        /// </summary>
        /// <param name="communityDbContext">The community database context.</param>
        public CommunityMembersRepository(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}
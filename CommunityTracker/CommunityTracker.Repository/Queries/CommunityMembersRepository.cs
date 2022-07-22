using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Queries
{
    public partial class CommunityMembersRepository : ICommunityRepositoryMembers
    {
        private readonly CommunityDbContext _communityDbContext;

        public CommunityMembersRepository(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}
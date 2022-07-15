using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        private readonly CommunityDbContext _communityDbContext;

        public CommunityRepositoryQuery(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}
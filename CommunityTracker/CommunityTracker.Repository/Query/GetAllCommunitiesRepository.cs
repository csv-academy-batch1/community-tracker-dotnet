using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        public IQueryable<Community> GetAllCommunities()
        {
            return _communityDbContext.community.AsQueryable();
        }
    }
}

using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        public IQueryable<CommunityManagers> GetAllCommunityManagers()
        {
            return _communityDbContext.communityadminandmanager.AsQueryable();
        }
    }
}
using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;
namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQuery
    {
        IQueryable<Community> GetAllCommunities();
        IQueryable<CommunityManagers> GetAllCommunityManagers();
    }
}
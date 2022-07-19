using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;
namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQuery
    {
        Task<Community> GetAllCommunities();
        Task<CommunityManagers> GetAllCommunityManagers();
    }
}

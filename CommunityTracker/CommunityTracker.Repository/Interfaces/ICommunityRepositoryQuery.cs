using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQuery
    {
        Task<List<Community>> GetAllCommunities();
        Task<Community> GetCommunityById(int id);
        Task<List<CommunityManagers>> GetAllManagers();
        Task<CommunityManagers> GetCommunityManagersById(int id);
    }
}

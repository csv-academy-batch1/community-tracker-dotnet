using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQuery
    {
        Task <List<Community>> GetAllCommunities();
        Task <List<CommunityManagers>> GetAllCommunityManagers();
    }
}

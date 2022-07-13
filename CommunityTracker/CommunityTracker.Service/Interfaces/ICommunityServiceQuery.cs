using CommunityTracker.Service.DTO;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceQuery
    {
        IEnumerable<CommunityDTO> GetAllCommunities();
        IEnumerable<CommunityManagersDTO> GetAllCommunityManagers();
    }
}
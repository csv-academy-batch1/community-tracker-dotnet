using CommunityTracker.Service.DTO;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceQuery
    {
        Task<List<CommunityDTOResponse>> GetAllCommunities();
        Task<List<CommunityManagersDTO>> GetAllCommunityManagers();
    }
}

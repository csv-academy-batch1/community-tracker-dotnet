using CommunityTracker.Service.DTO;
using CommunityTracker.Service.ServicesDTO;
namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceQuery
    {
        Task<IEnumerable<CommunityDTOResponse>> GetAllCommunities();
        Task<IEnumerable<CommunityManagersDTO>> GetAllCommunityManagers();
    }
}

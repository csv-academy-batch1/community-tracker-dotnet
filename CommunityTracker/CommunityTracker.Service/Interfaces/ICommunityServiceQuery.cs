using CommunityTracker.Service.DTO;
using CommunityTracker.Service.ServicesDTO;
namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceQuery
    {
        IEnumerable<CommunityDTOResponse> GetAllCommunities();
        IEnumerable<CommunityManagersDTO> GetAllCommunityManagers();
    }
}

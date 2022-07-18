using CommunityTracker.Service.DTO;
using CommunityTracker.Service.ServicesDTO;
namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceCommands
    {
        Task<CommunityResponseDTO> AddCommunityService(CommunityDTO communityDTO);
    }
}
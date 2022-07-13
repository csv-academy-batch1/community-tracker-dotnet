using CommunityTracker.Service.DTO;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceCommands
    {
        AddCommunityResponseDTO AddCommunityService(CommunityDTO communityDTO);
    }
}
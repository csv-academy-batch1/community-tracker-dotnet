using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityMembersService 
    {
        Task<List<CommunityMembersDTO>> GetAllCommunityMembers();
    }
}

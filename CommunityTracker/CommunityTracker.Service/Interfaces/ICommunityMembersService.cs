using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommunityMembersService 
    {
        /// <summary>
        /// Gets all community members.
        /// </summary>
        /// <returns></returns>
        Task<List<CommunityMembersDTO>> GetAllCommunityMembers();
    }
}

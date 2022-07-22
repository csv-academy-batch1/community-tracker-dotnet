using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public interface ICommunityServiceQueries
    {
        /// <summary>
        /// Gets all communities.
        /// </summary>
        /// <returns></returns>
        Task<List<CommunityDTOResponse>> GetAllCommunities();

        /// <summary>
        /// Gets all community managers.
        /// </summary>
        /// <returns></returns>
        Task<List<CommunityManagersDTO>> GetAllCommunityManagers();
        
    }
}
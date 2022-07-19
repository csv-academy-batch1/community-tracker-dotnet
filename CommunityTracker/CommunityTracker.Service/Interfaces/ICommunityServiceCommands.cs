using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.ServicesDTO;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public interface ICommunityServiceCommands
    {
        /// <summary>
        /// Adds the community service.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        Task<CommunityResponseDTO> AddCommunityService(CommunityDTO communityDTO);
    }
}
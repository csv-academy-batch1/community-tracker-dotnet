using CommunityTracker.Repository.RepositoryDTO;
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
        Task<CommunityResponseDTO> AddCommunity(CommunityDTO communityDTO);

        /// <summary>Updates the community.</summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<CommunityResponseDTO> UpdateCommunity(CommunityDTO communityDTO);
    }
}
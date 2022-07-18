using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQuery
    {
        /// <summary>
        /// Gets all communities.
        /// </summary>
        /// <returns></returns>
        Task<List<Community>> GetAllCommunities();

        /// <summary>
        /// Gets the community by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<Community> GetCommunityById(int id);

        /// <summary>
        /// Gets all managers.
        /// </summary>
        /// <returns></returns>
        Task<List<CommunityManagers>> GetAllManagers();

        /// <summary>
        /// Gets the community managers by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<CommunityManagers> GetCommunityManagersById(int id);
    }
}
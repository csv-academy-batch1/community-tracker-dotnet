using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQueries
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

        /// <summary>
        /// Gets the name of all communities with manager name.
        /// </summary>
        /// <param name="managerId">The manager identifier.</param>
        /// <param name="communityName">Name of the community.</param>
        /// <returns></returns>
        Task<CommunityDetails> GetCommunitiesWithManagerName(int? managerId, string communityName);
    }
}
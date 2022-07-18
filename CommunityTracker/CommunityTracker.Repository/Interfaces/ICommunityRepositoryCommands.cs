using CommunityTracker.Repository.Entities;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryCommands
    {
        /// <summary>Adds the community repository.</summary>
        /// <param name="communityData">The community data.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task AddCommunityRepository(Community communityData);

        /// <summary>
        /// Updates the community repository.
        /// </summary>
        /// <param name="communityData">The community data.</param>
        /// <returns></returns>
        Task UpdateCommunityRepository(Community communityData);
    }
}
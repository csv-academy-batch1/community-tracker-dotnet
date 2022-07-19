using CommunityTracker.Repository.RepositoryDTO;

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
        Task UpdateCommunityRepository(Community communityData);
    }
}
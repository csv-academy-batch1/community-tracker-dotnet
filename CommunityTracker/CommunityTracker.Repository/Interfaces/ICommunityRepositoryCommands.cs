using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryCommands
    {
        /// <summary>Adds the community to the database</summary>
        /// <param name="communityData">The community data.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task AddCommunity(Community communityData);

        /// <summary>Updates the community to the database.</summary>
        /// <param name="communityData">The community data.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task UpdateCommunity(Community communityData);
    }
}
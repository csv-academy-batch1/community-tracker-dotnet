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
        Task<RepositoryResponse> AddCommunity(Community communityData);
        Task<RepositoryResponse> UpdateCommunity(Community communityData);
    }
}
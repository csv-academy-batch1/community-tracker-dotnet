using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Commands
{
    /// <summary>
    /// CommunityRepositoryCommands
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryCommands" />
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>
        /// Adds the community to the database.
        /// </summary>
        /// <param name="communityData">The community data.</param>
        public async Task<AddRepositoryResponse> AddCommunity(Community communityData)
        {
            var response = new AddRepositoryResponse();
            try
            {
                await _communityDbContext.AddAsync(communityData);
                await SaveChangesAsync();

                response.ResultMessage = "Success";
            }
            catch (Exception)
            {
                response.ResultMessage = "Server Error";
            }

            return response;
        }

    }
}
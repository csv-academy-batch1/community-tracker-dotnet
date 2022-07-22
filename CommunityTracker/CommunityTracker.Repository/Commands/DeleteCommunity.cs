using CommunityTracker.Repository.ConnectionHandler;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;


namespace CommunityTracker.Repository.Commands
{
    /// <summary>
    ///   <br />
    /// </summary>
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>Deletes the community.</summary>
        /// <param name="community">The community.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<RepositoryResponse> DeleteCommunity(Community community)
        {
            var response = new RepositoryResponse();
            try
            {
            var communityDataExists = _communityDbContext.community.FirstOrDefault( x => x.CommunityId == community.CommunityId && x.IsActive == true);

            if (communityDataExists != null)
            { 
                communityDataExists.IsActive = false;
                await SaveChangesAsync();
            }

            }
            catch (Exception)
            {
                response.ResultMessage = "Server Error";
            }
            finally 
            { 
                CloseConnection.DisposeConnection();
            }

            return response;
        }
    }
}

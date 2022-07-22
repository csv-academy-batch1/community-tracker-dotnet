using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Repository.Interfaces;
using System.Data.Entity;
using CommunityTracker.Repository.ConnectionHandler;

namespace CommunityTracker.Repository.Commands
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>Updates the community.</summary>
        /// <param name="communityData">The community data.</param>
        public async Task<UpdateRepositoryResponse> UpdateCommunity(Community communityData)
        {
            var response = new UpdateRepositoryResponse();

            try
            {
                var isIdExisting = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
                if (isIdExisting != null && isIdExisting.CommunityId == communityData.CommunityId)
                {
                    isIdExisting.CommunityName = communityData.CommunityName;
                    isIdExisting.CommunityMgrid = communityData.CommunityMgrid;
                    isIdExisting.CommunityDesc = communityData.CommunityDesc;
                }
                await SaveChangesAsync();

                response.ResultMessage = "Success";
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
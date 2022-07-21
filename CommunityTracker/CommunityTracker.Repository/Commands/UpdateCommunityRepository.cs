using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Commands
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        /// <summary>Updates the community.</summary>
        /// <param name="communityData">The community data.</param>
        public async Task UpdateCommunity(Community communityData)
        {
            try
            {
                var idCheck = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
                if (idCheck != null)
                {
                    idCheck.CommunityName = communityData.CommunityName;
                    idCheck.CommunityMgrid = communityData.CommunityMgrid;
                    idCheck.CommunityDesc = communityData.CommunityDesc;
                }
                await SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
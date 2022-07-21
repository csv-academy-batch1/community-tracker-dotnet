using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Commands
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Repository.Interfaces.ICommunityRepositoryCommands" />
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public async Task DeleteCommunity(Community communityData)
        {
            try
            {
                var community = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);

                if (community != null)
                {
                    community.IsActive = false;
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
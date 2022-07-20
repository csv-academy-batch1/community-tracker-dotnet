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
        public async Task UpdateCommunity(Community communityData)
        {
            //var community = new Community()
            //{
            //    CommunityId = communityData.CommunityId,
            //    CommunityName = communityData.CommunityName,
            //    CommunityMgrid = communityData.CommunityMgrid,
            //    CommunityDesc = communityData.CommunityDesc
            //};
            var idCheck = _communityDbContext.community.FirstOrDefault(x => x.CommunityId == communityData.CommunityId);
            if (idCheck != null)
            {
                idCheck.CommunityName = communityData.CommunityName;
                idCheck.CommunityMgrid = communityData.CommunityMgrid;
                idCheck.CommunityDesc = communityData.CommunityDesc;
            }
            await SaveChangesAsync();
            //_communityDbContext.community.Update(idCheck);
        }
    }
}
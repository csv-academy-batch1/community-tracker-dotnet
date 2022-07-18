using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Command
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceCommands" />
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        /// <summary>
        /// Adds the community service.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        public async Task<CommunityResponseDTO> AddCommunityService(CommunityDTO communityDTO)
        {
            var community = new CommunityResponseDTO();
            var allcommunities = await _communityRepositoryQuery.GetAllCommunities();
            bool communityExists = allcommunities.Any(x => x.CommunityName.ToLower() == communityDTO.communityname.ToLower());
            if (communityExists)
            {
                return null;
            }
            await _communityRepositoryCommands.AddCommunityRepository(new Community()
            {
                CommunityName = communityDTO.communityname,
                CommunityDesc = communityDTO.communitydesc,
                CommunityMgrid = communityDTO.communitymgrid,
            });
            community = await MapAddCommunityResponse(communityDTO);
            if (community is null)
            {
                return null;
            }
            return community;
        }

        /// <summary>
        /// Maps the add community response.
        /// </summary>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns></returns>
        private async Task<CommunityResponseDTO> MapAddCommunityResponse(CommunityDTO communityDTO)
        {
            var managers = await _communityRepositoryQuery.GetCommunityManagersById((int)communityDTO.communitymgrid);
            var allmanagers = await _communityRepositoryQuery.GetAllCommunities();
            var community = allmanagers.Select(x => new CommunityResponseDTO()
            {
                communityid = x.CommunityId,
                communityname = x.CommunityName,
                communitymanagername = managers.CommunityAdminAndManagerName,
                communitydesc = x.CommunityDesc
            }).ToList().FirstOrDefault(c => c.communityname == communityDTO.communityname);
            return community;
        }
    }
}
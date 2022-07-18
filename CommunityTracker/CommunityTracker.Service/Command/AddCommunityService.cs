using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityResponseDTO> AddCommunityService(CommunityDTO communityDTO)
        {
            var communities = new CommunityResponseDTO();
            var coms = await _communityRepositoryQuery.GetAllCommunities();
            bool communityExists = coms.Any(x => x.CommunityName.ToLower() == communityDTO.communityname.ToLower());
            if (communityExists)
            {
                return null;
            }
            await _communityRepositoryCommands.AddCommunityRepository(new Community()
            {
                CommunityId = communityDTO.communityid,
                CommunityName = communityDTO.communityname,
                CommunityDesc = communityDTO.communitydesc,
                CommunityMgrid = communityDTO.communitymgrid,
                CommunityIcon = communityDTO.communityicon,
                IsActive = communityDTO.isactive
            });
            var allCommunities = await AddCommunityResponse();
            communities = allCommunities.FirstOrDefault(c => c.communityname == communityDTO.communityname);
            if (communities is null)
            {
                return null;
            }
            return communities;
        }

        private async Task <List<CommunityResponseDTO>> AddCommunityResponse()
        {
            var managers = await _communityRepositoryQuery.GetAllCommunityManagers();
            var coms = await _communityRepositoryQuery.GetAllCommunities();
            var getAllCommunities = coms.Select(x => new CommunityResponseDTO()
            {
                communityid = x.CommunityId,
                communityname = x.CommunityName,
                communitymanagername = managers.Where(m => m.CommunityAdminAndManagerId == x.CommunityMgrid)
                .Select(x => x.CommunityAdminAndManagerName).FirstOrDefault(),
                communitydesc = x.CommunityDesc
            }).ToList();
            return getAllCommunities;
        }
    }
}
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
            bool communityExists = _communityRepositoryQuery.GetAllCommunities().Any(x => x.CommunityName.ToLower() == communityDTO.communityname.ToLower());
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
            var allCommunities = AddCommunityResponse();
            communities = allCommunities.FirstOrDefault(c => c.communityname == communityDTO.communityname);
            if (communities is null)
            {
                return null;
            }
            return communities;
        }
        private IEnumerable<CommunityResponseDTO> AddCommunityResponse()
        {
            var managers = _communityRepositoryQuery.GetAllCommunityManagers();
            var getAllCommunities = _communityRepositoryQuery.GetAllCommunities().Select(x => new CommunityResponseDTO()
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